using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Core;
using HIS.Service.Core.Enums;
using HIS.Utility;
using HIS.Service;

namespace HIS.Services
{
    public class CatalogService : ICatalogService
    {
        /// <summary>
        /// 获取目录
        /// </summary>
        /// <returns></returns>
        public DataResult<List<CatalogEntity>> GetAll()
        {
            try
            {
                List<CatalogEntity> catalogEntities = DBHelper.Instance.HIS.From<Dic_Catalog>()
                      .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete)
                      .Select(Dic_Catalog._.Id, Dic_Catalog._.ParentId, Dic_Catalog._.Name, Dic_Catalog._.Description, Dic_Catalog._.DataStatus, Dic_Catalog._.No)
                      .OrderBy(d => d.No)
                      .ToList<Dic_Catalog>()
                      .Mapper<List<CatalogEntity>>();

                return DataResult.True<List<CatalogEntity>>(catalogEntities);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<CatalogEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 获取序号
        /// </summary>
        /// <param name="parentId">父节点Id</param>
        /// <returns></returns>
        public int GetNo(long parentId)
        {
            int maxNo = DBHelper.Instance.HIS.From<Dic_Catalog>().Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.ParentId == parentId && d.DataStatus != (int)DataStatus.Delete)
                .Select(Dic_Catalog._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="catalogEntity"></param>
        /// <returns></returns>
        public DataResult Add(CatalogEntity catalogEntity)
        {
            try
            {
                Dic_Catalog dicCatalog = catalogEntity.Mapper<Dic_Catalog>();
                dicCatalog.SetCreationValues();

                DBHelper.Instance.HIS.Insert<Dic_Catalog>(dicCatalog);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 修改目录名称
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataResult UpdateNameById(string name, long id)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_Catalog>();
                updateValue[Dic_Catalog._.Name] = name;

                DBHelper.Instance.HIS.Update<Dic_Catalog>(updateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        //        private string _use;
        //        private AppType _appType;
        //        private IIdService _idService;

        //        public CatalogService(IIdService idService)
        //        {
        //            this._idService = idService;
        //        }

        //        /// <summary>
        //        /// 用于数据源目录
        //        /// </summary>
        //        /// <param name="appType"></param>
        //        /// <param name="use"></param>
        //        public void UseDataSource(AppType appType,BusinessPurpose use)
        //        {
        //            this.Use(nameof(Dic_DataSource)+'_'+Enum.GetName(typeof(BusinessPurpose),use), appType);
        //        }
        //        /// <summary>
        //        /// 获取数据源目录
        //        /// </summary>
        //        public void UseDataSource(AppType appType)
        //        {
        //            this.Use(nameof(Dic_DataSource), appType);
        //        }
        //        /// <summary>
        //        /// 用于数据元目录
        //        /// </summary>
        //        public void UseDataElement()
        //        {
        //            this.Use(nameof(Dic_DataElement), AppType.None);
        //        }
        //        /// <summary>
        //        /// 用于系统字典目录
        //        /// </summary>
        //        public void UseSysDic()
        //        {
        //            this.Use(nameof(Sys_Dic), AppType.None);
        //        }
        //        /// <summary>
        //        /// 用于常用短语目录
        //        /// </summary>
        //        public void UsePhrase()
        //        {
        //            this.Use(nameof(Dic_Phrase), AppType.None);
        //        }
        //        /// <summary>
        //        /// 使用用途
        //        /// </summary>
        //        /// <param name="use">用途 一般为业务表名称</param>
        //        /// <param name="appType">应用类型</param>
        //        private void Use(string use, AppType appType = AppType.None)
        //        {
        //            use.CheckNotNullOrEmpty(nameof(use));
        //            this._use = use.ToUpper();
        //            this._appType = appType;
        //        }
        //        /// <summary>
        //        /// 获取目录列表
        //        /// </summary>
        //        /// <param name="includeDisable"></param>
        //        /// <returns></returns>
        //        public List<CatalogEntity> GetCatalogs(bool includeDisable=false)
        //        {
        //            if (includeDisable)
        //            return  AutoMapper.Mapper.Map<List<CatalogEntity>>(DBHelper.Instance.HIS.From<Dic_Catalog>()
        //                    .Select(new Dic_Catalog().GetQueryFields())
        //                    .Where(d => d.HosId == App.Current.RuntimeSystemInfo.HospitalInfo.Id && (d.AppType == (int)this._appType) && d.Use == this._use && d.Staus != (int)Status.Delete).OrderBy(o => o.No).ToList());
        //            return AutoMapper.Mapper.Map<List<CatalogEntity>>(DBHelper.Instance.HIS.From<Dic_Catalog>()
        //                .Select(new Dic_Catalog().GetQueryFields())
        //                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && (d.AppType == (int)this._appType ) && d.Use == this._use && d.Staus == (int)Status.Enable).OrderBy(o => o.No).ToList());
        //        }
        //        /// <summary>
        //        /// 获取目录列表
        //        /// </summary>
        //        /// <param name="includeDisable"></param>
        //        /// <returns></returns>
        //        public List<CatalogEntity> GetCatalogs(OwnerIdentif ownerIdentif,bool includeDisable = false)
        //        {
        //            if (includeDisable)
        //                return AutoMapper.Mapper.Map<List<CatalogEntity>>(DBHelper.CIS.From<Dic_Catalog>()
        //                        .Select(new Dic_Catalog().GetQueryFields())
        //                        .Where(d => d.HosId == App.Current.RuntimeSystemInfo.HospitalInfo.Id 
        //                        && (d.AppType == (int)this._appType)
        //                        && d.Use == this._use && d.Staus != (int)Status.Delete
        //                        && d.OwnerType==(int)ownerIdentif.OwnerType
        //                        && d.OwnerId == ownerIdentif.OwnerId
        //                        ).OrderBy(o => o.No).ToList());
        //            return AutoMapper.Mapper.Map<List<CatalogEntity>>(DBHelper.CIS.From<Dic_Catalog>()
        //                .Select(new Dic_Catalog().GetQueryFields())
        //                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id 
        //                && (d.AppType == (int)this._appType) 
        //                && d.Use == this._use && d.Staus == (int)DataStatus.Enable
        //                && d.OwnerType == (int)ownerIdentif.OwnerType
        //                && d.OwnerId == ownerIdentif.OwnerId)
        //                .OrderBy(o => o.No).ToList());
        //        }
        //        /// <summary>
        //        /// 创建目录
        //        /// </summary>
        //        /// <param name="parentId">父节点Id</param>
        //        /// <param name="name">目录名称</param>
        //        /// <param name="ownerType">所属者类型</param>
        //        /// <param name="ownerId">所属者ID</param>
        //        /// <returns></returns>
        //        public CatalogEntity Create(long? parentId, string name, OwnerType ownerType = OwnerType.None, string ownerId = null)
        //        {
        //            name.CheckNotNullOrEmpty(nameof(name));
        //            ownerType.Required(d => (d != OwnerType.None && !ownerId.IsNullOrWhiteSpace()) || d == OwnerType.None, "请指定ownerId值");
        //            long pid = parentId.AsLong(0);
        //            int maxNo = DBHelper.CIS.From<Dic_Catalog>().Where(d =>d.HosId==CIS.Core.App.Current.RuntimeSystemInfo.HospitalInfo.Id && d.ParentId == pid && d.Use == _use).Select(Dic_Catalog._.No.Max()).ToScalar<int>();
        //            Dic_Catalog catalog = new Dic_Catalog();
        //            catalog.SetCreationValues();
        //            catalog.Id = this._idService.CreateUUID();
        //            catalog.Name = name.Trim();
        //            catalog.AppType = (int)_appType;
        //            catalog.Use = _use;
        //            catalog.ParentId = pid;
        //            catalog.NodeType = (int)CatalogNodeType.Catalog;
        //            catalog.OwnerType = (int)ownerType;
        //            catalog.OwnerId = ownerId;
        //            catalog.No = maxNo + 1;

        //            DBHelper.Instance.HIS.Insert(catalog);
        //            return AutoMapper.Mapper.Map<CatalogEntity>(catalog);
        //        }
        //        /// <summary>
        //        /// 重命名
        //        /// </summary>
        //        /// <param name="id">目录ID</param>
        //        /// <param name="name">新名称</param>
        //        /// <returns></returns>
        //        public bool Rename(long id, string name)
        //        {
        //            name.CheckNotNullOrEmpty(nameof(name));
        //            Dictionary<Dos.ORM.Field, object> updateValue = new Dictionary<Dos.ORM.Field, object>();
        //            updateValue[Dic_Catalog._.Name] = name.Trim();
        //            updateValue[Dic_Catalog._.LastModifierUserId] = App.Instance.RuntimeSystemInfo.UserInfo.Id;
        //            updateValue[Dic_Catalog._.LastModificationTime] = DBHelper.Instance.ServerTime;
        //            return DBHelper.Instance.HIS.Update<Dic_Catalog>(updateValue, d =>d.HosId==App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id && d.Staus != (int)DataStatus.Delete) == 1;
        //        }
        //        /// <summary>
        //        /// 删除目录
        //        /// </summary>
        //        /// <param name="id"></param>
        //        /// <returns></returns>
        //        public DataResult Delete(long id)
        //        {
        //            Dictionary<Dos.ORM.Field, object> updateValue =  AuditionHelper.GetDeletionValues<Dic_Catalog>();
        //            DBHelper.Instance.HIS.Update<Dic_Catalog>(updateValue, d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id && d.Staus != (int)DataStatus.Delete);
        //            return DataResult.True();
        //        }
        //        /// <summary>
        //        /// 删除目录
        //        /// </summary>
        //        /// <param name="ids"></param>
        //        /// <returns></returns>
        //        public DataResult Delete(long[] ids)
        //        {
        //            if (ids == null || ids.Length == 0) return DataResult.True();
        //            if (ids.Length == 1)
        //                return this.Delete(ids[0]);
        //            Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetDeletionValues<Dic_Catalog>();
        //            DBHelper.Instance.HIS.Update<Dic_Catalog>(updateValue, d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id.In(ids) && d.Staus != (int)DataStatus.Delete);
        //            return DataResult.True();
        //        }
        //        /// <summary>
        //        /// 变更文件夹
        //        /// </summary>
        //        /// <param name="id"></param>
        //        /// <param name="parentId"></param>
        //        /// <returns></returns>
        //        public bool ChangeFolder(long id, long parentId)
        //        {
        //            var updateValues = AuditionHelper.GetModificationValues<Dic_Catalog>();
        //            updateValues[Dic_Catalog._.ParentId] = parentId;
        //            return DBHelper.Instance.HIS.Update<Dic_Catalog>(updateValues, d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id)==1;
        //        }

        //        /// <summary>
        //        /// Debug模式下的测试删除
        //        /// </summary>
        //        /// <param name="catalogIds"></param>
        //        /// <returns></returns>
        //        public DataResult TestDelete(long[] catalogIds)
        //        {
        //            DBHelper.Instance.HIS.Delete<Dic_Catalog>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id.In(catalogIds));
        //            return DataResult.True();
        //        }

        //        /// <summary>
        //        /// 获取目录id
        //        /// </summary>
        //        /// <param name="parentId">父节点ID</param>
        //        /// <returns></returns>
        //        public List<long> GetCatalogIdList(long parentId, string use)
        //        {
        //            return DBHelper.Instance.HIS.FromSql(@"with activerecord_cte
        //as
        //(
        //	select Id from Dic_Catalog where ParentId=@ParentId
        //	union all
        //	select d.Id from Dic_Catalog d 
        //	inner join activerecord_cte ar 
        //	on d.ParentId=ar.Id 
        //	where  d.HosId=@HosId and d.Staus!=@Staus and d.[Use]=@Use 
        //)
        //select * from activerecord_cte")
        //.AddInParameter("@ParentId", System.Data.DbType.Int64, parentId)
        //.AddInParameter("@Staus", System.Data.DbType.Int32, (int)DataStatus.Delete)
        //.AddInParameter("@Use", System.Data.DbType.String, use)
        //.AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList<long>();
        //        }


    }
}
