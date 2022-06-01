using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class DeptService : IDeptService
    {
        private readonly IIdService _idService;

        public DeptService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取所有科室
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<DeptEntity> GetList(bool includeDisable = false)
        {
            if (includeDisable)
                return DBHelper.Instance.HIS.From<View_Dept>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DefaultDept == false && d.DataStatus != (int)DataStatus.Delete)
                    .OrderBy(a => a.No)
                    .ToList().Mapper<List<DeptEntity>>();
            return DBHelper.Instance.HIS.From<View_Dept>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DefaultDept == false && d.DataStatus == (int)DataStatus.Enable)
                .OrderBy(a => a.No)
                .ToList().Mapper<List<DeptEntity>>();
        }

        /// <summary>
        /// 获取系统拥有的科室列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public List<DeptEntity> GetListByApp(long appId)
        {
            return DBHelper.Instance.HIS.FromSql(@"select d.*  from View_Dept d
inner join Sys_AppDeptMapper ud on d.hosid=ud.hosid and  d.ID = ud.DeptId 
where ud.AppId=@uid and d.DataStatus=1
order by ud.no asc")
.AddInParameter("@uid", System.Data.DbType.String, appId).ToList<View_Dept>().Mapper<List<DeptEntity>>();
        }
        /// <summary>
        /// 获取指定系统拥有的默认科室
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public List<DeptEntity> GetDefaultByApp(long appId)
        {
            string sql = $@"
select a.* from View_Dept a
left join Sys_AppDeptMapper b on a.Id=b.DeptId
where b.AppId={appId} and a.DefaultDept=1 and a.DataStatus=1
";
            return DBHelper.Instance.HIS.FromSql(sql).ToList<View_Dept>().Mapper<List<DeptEntity>>();
        }
        /// <summary>
        /// 获取指定用户拥有的所有科室
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<DeptEntity> GetByUser(long userId, long roleId)
        {
            return DBHelper.Instance.HIS.From<Sys_UserDeptMapper>().LeftJoin<View_Dept>((p, d) => p.DeptId == d.Id).Select(View_Dept._.All).Where(Sys_UserDeptMapper._.UserId == userId && Sys_UserDeptMapper._.RoleId == roleId && Sys_UserDeptMapper._.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && View_Dept._.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList<View_Dept>().Mapper<List<DeptEntity>>();
        }
        /// <summary>
        /// 停用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult DisableDept(long deptId)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_Dept>();
                modify[Sys_Dept._.DataStatus] = DataStatus.Disable;

                DBHelper.Instance.HIS.Update<Sys_Dept>(modify, p => p.Id == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 停用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult DisableDepts(List<long> deptIds)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_Dept>();
                modify[Sys_Dept._.DataStatus] = DataStatus.Disable;

                DBHelper.Instance.HIS.Update<Sys_Dept>(modify, p => p.Id.In(deptIds) && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 停用指定科室,并重置指定科室的上级科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="idAndParentId"></param>
        /// <returns></returns>
        public DataResult DisableDeptWithUpgrade(long deptId, Dictionary<long, long> idAndParentId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        var parentModify = AuditionHelper.GetModificationValues<Sys_Dept>();
                        parentModify[Sys_Dept._.DataStatus] = (int)DataStatus.Disable;
                        batch.Update<Sys_Dept>(parentModify, new WhereClip(Sys_Dept._.Id, deptId, QueryOperator.Equal).And(new WhereClip(Sys_Dept._.HosId, App.Instance.RuntimeSystemInfo.HospitalInfo.Id, QueryOperator.Equal)));

                        var childModify = AuditionHelper.GetModificationValues<Sys_Dept>();
                        foreach (var item in idAndParentId)
                        {
                            childModify[Sys_Dept._.ParentId] = item.Value;
                            batch.Update<Sys_Dept>(childModify, new WhereClip(Sys_Dept._.Id, item.Key, QueryOperator.Equal).And(new WhereClip(Sys_Dept._.HosId, App.Instance.RuntimeSystemInfo.HospitalInfo.Id, QueryOperator.Equal)));
                        }
                    }
                    tran.Commit();
                    return DataResult.True();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    return DataResult.Fault(ex.Message);
                }
            }
        }
        /// <summary>
        /// 启用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult EnableDept(long deptId)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_Dept>();
                modify[Sys_Dept._.DataStatus] = DataStatus.Enable;

                DBHelper.Instance.HIS.Update<Sys_Dept>(modify, p => p.Id == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新科室
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public DataResult UpdateDept(DeptEntity deptEntity)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_Dept>();
                modify[Sys_Dept._.Name] = deptEntity.Name;
                modify[Sys_Dept._.AliasName] = deptEntity.AliasName;
                modify[Sys_Dept._.CategoryId] = deptEntity.Category.Id;
                modify[Sys_Dept._.Location] = deptEntity.Location;
                modify[Sys_Dept._.ParentId] = deptEntity.Parent == null ? 0 : deptEntity.Parent.Id;
                modify[Sys_Dept._.SearchCode] = deptEntity.SearchCode;
                modify[Sys_Dept._.CategoryDetail] = deptEntity.CategoryDetail;

                DBHelper.Instance.HIS.Update<Sys_Dept>(modify, p => p.Id == deptEntity.Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 添加科室
        /// </summary>
        /// <param name="deptEntity"></param>
        /// <returns></returns>
        public DataResult AddDept(DeptEntity deptEntity)
        {
            try
            {
                var insert = deptEntity.Mapper<Sys_Dept>();
                insert.CategoryDetail = 0;
                insert.SetCreationValues();
                insert.Id = _idService.CreateUUID();

                DBHelper.Instance.HIS.Insert(insert);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 科室编号是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ExistCode(string code)
        {
            return DBHelper.Instance.HIS.Exists<Sys_Dept>(p => p.Code == code && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
        }
        /// <summary>
        /// 获取指定明细分类的科室列表
        /// </summary>
        /// <param name="categoryDetail"></param>
        /// <returns></returns>
        public List<DeptEntity> GetList(DeptCategoryDetail categoryDetail)
        {
            return DBHelper.Instance.HIS.From<View_Dept>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.CategoryDetail == (int)categoryDetail).ToList().Mapper<List<DeptEntity>>();
        }

        /// <summary>
        /// 根据指定类型查询 可有多个类型
        /// </summary>
        /// <param name="categoryDetailList"></param>
        /// <returns></returns>
        public List<DeptEntity> GetListByCategoryDetail(List<DeptCategoryDetail> categoryDetailList)
        {
            WhereClip where = WhereClip.All;
            where = where.And(View_Dept._.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

            for (int i = 0; i < categoryDetailList.Count; i++)
            {
                DeptCategoryDetail detail = categoryDetailList[i];

                if (i > 0)
                {
                    where = where.Or(View_Dept._.CategoryDetail == (int)detail);
                }
                else
                {
                    where = where.And(View_Dept._.CategoryDetail == (int)detail);
                }
            }
            return DBHelper.Instance.HIS.From<View_Dept>().Where(where).ToList().Mapper<List<DeptEntity>>();

        }

        /// <summary>
        /// 获取指定科室对应的药房 
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DeptEntity> GetPharmacy(long deptId)
        {
            return DBHelper.Instance.HIS.From<View_DeptPharmacyMapper>().Where(p => p.DeptId == deptId).ToList().Mapper<List<DeptEntity>>();
        }
        /// <summary>
        /// 获取科室对应药房
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DeptPharmacyEntity> GetPharmacyMapper(long deptId)
        {
            return DBHelper.Instance.HIS.From<View_DeptPharmacyMapper>().Where(p => p.DeptId == deptId).ToList().Mapper<List<DeptPharmacyEntity>>();
        }
        /// <summary>
        /// 增加科室对应药房关系
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="pharmacyId"></param>
        /// <returns></returns>
        public DataResult<DeptPharmacyEntity> AddMapper(long deptId, long pharmacyId)
        {
            try
            {
                DeptPharmacyEntity entity = new DeptPharmacyEntity();
                entity.Id = _idService.CreateUUID();
                entity.DeptId = deptId;
                entity.PharmacyId = pharmacyId;
                DBHelper.Instance.HIS.Delete<Dic_DeptPharmacyMapper>(Dic_DeptPharmacyMapper._.DeptId == deptId && Dic_DeptPharmacyMapper._.PharmacyId == pharmacyId);
                var model = entity.Mapper<Dic_DeptPharmacyMapper>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<Dic_DeptPharmacyMapper>(model);

                return DataResult.True<DeptPharmacyEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<DeptPharmacyEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除科室对应药房关系
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<DeptPharmacyEntity> DeleteMapper(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_DeptPharmacyMapper>(Dic_DeptPharmacyMapper._.Id == entityId);
                return DataResult.True<DeptPharmacyEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DeptPharmacyEntity>(ex.Message);
            }
        }

        /// <summary>
        /// 删除科室对应药房关系
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<DeptPharmacyEntity> DeleteMapper(long deptId, long pharmacId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_DeptPharmacyMapper>(Dic_DeptPharmacyMapper._.DeptId == deptId && Dic_DeptPharmacyMapper._.PharmacyId == pharmacId);
                return DataResult.True<DeptPharmacyEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DeptPharmacyEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 根据指定分类查询
        /// </summary>
        /// <param name="deptCategory"></param>
        /// <returns></returns>
        public List<DeptEntity> GetListByCategory(DeptCategory deptCategory, DeptCategoryDetail categoryDetail = DeptCategoryDetail.None)
        {
            return DBHelper.Instance.HIS.From<View_Dept>().Where(p => p.CategoryName == deptCategory.ToString() && p.CategoryDetail == (int)categoryDetail).ToList().Mapper<List<DeptEntity>>();
        }
        /// <summary>
        /// 根据指定分类查询
        /// </summary>
        /// <param name="deptCategories"></param>
        /// <returns></returns>
        public List<DeptEntity> GetListByCategory(List<DeptCategory> deptCategories, DeptCategoryDetail categoryDetail = DeptCategoryDetail.None)
        {
            var categoryTexts = deptCategories.Select(p => p.ToString()).ToArray();

            return DBHelper.Instance.HIS.From<View_Dept>().Where(p => p.CategoryName.In(categoryTexts) && p.CategoryDetail == (int)categoryDetail).ToList().Mapper<List<DeptEntity>>();
        }
    }
}
