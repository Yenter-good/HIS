using Dos.ORM;
using HIS.Core;
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
    class AdviceService : IAdviceService
    {
        private IIdService _idService;
        public AdviceService(IIdService idService)
        {
            _idService = idService;
        }
        /// <summary>
        /// 获取单个医嘱信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AdviceEntity Get(long id)
        {
            var item = DBHelper.Instance.HIS.From<View_Advice>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id)
                .First();
            if (item != null)
            {
                return AutoMapperHelper.Instance.Mapper.Map<AdviceEntity>(item);
            }
            return null;
        }

        /// <summary>
        /// 获取所有医嘱
        /// </summary>
        /// <returns></returns>
        public List<AdviceEntity> GetAll()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<AdviceEntity>>(DBHelper.Instance.HIS.From<View_Advice>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList());
        }

        /// <summary>
        /// 根据医嘱类型获取所有
        /// </summary>
        /// <param name="type">医嘱类型</param>
        /// <returns></returns>
        public List<AdviceEntity> GetAllByType(AdviceType type)
        {

            return AutoMapperHelper.Instance.Mapper.Map<List<AdviceEntity>>(DBHelper.Instance.HIS.From<View_Advice>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Type == (int)type).ToList());
        }
        /// <summary>
        /// 根据 医嘱名称或拼音码查询
        /// </summary>
        /// <param name="searchCode">名称或拼音码</param>
        /// <param name="type">医嘱类型</param>
        /// <returns></returns>
        public List<AdviceEntity> GetByConditions(string searchStr, AdviceType type)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<AdviceEntity>>(DBHelper.Instance.HIS.From<View_Advice>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Type == (int)type && (d.SearchCode.Contains(searchStr) || d.Name.Contains(searchStr))).ToList());
        }
        /// <summary>
        /// 新增医嘱
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<AdviceEntity> InsertAdvice(AdviceEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();
                var model = entity.Mapper<Dic_Advice>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<Dic_Advice>(model);

                return DataResult.True<AdviceEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<AdviceEntity>(ex.Message);
            }

        }
        /// <summary>
        /// 更新医嘱
        /// </summary>
        /// <param name="entityId">医嘱ID</param>
        /// <param name="entity">医嘱实体</param>
        /// <returns></returns>
        public DataResult<AdviceEntity> UpdateAdvice(long entityId, AdviceEntity entity)
        {

            try
            {
                var modelModify = AuditionHelper.GetModificationValues<Dic_Advice>();
                modelModify[Dic_Advice._.Name] = entity.Name;
                modelModify[Dic_Advice._.DataStatus] = (int)entity.DataStatus;
                modelModify[Dic_Advice._.Price] = entity.Price;
                modelModify[Dic_Advice._.SearchCode] = entity.SearchCode;
                modelModify[Dic_Advice._.WubiCode] = entity.WubiCode;
                modelModify[Dic_Advice._.Type] = entity.Type;
                modelModify[Dic_Advice._.SampleId] = entity.Sample?.Key;
                modelModify[Dic_Advice._.BuretId] = entity.Buret?.Key;
                modelModify[Dic_Advice._.PartId] = entity.Part?.Key;
                modelModify[Dic_Advice._.ModalityId] = entity.Modality?.Key;
                modelModify[Dic_Advice._.OFlag] = entity.OFlag;
                modelModify[Dic_Advice._.IFlag] = entity.IFlag;
                modelModify[Dic_Advice._.SFlag] = entity.SFlag;
                modelModify[Dic_Advice._.MFlag] = entity.MFlag;

                DBHelper.Instance.HIS.Update<Dic_Advice>(modelModify, p => p.Id == entity.Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True<AdviceEntity>(entity);
            }
            catch (Exception ex)
            {

                return DataResult.Fault<AdviceEntity>(ex.Message);
            }

        }

        /// <summary>
        /// 医嘱停用或启用
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="status">0停用 1启用</param>
        /// <returns></returns>
        public DataResult<AdviceEntity> StopAdvice(long entityId, DataStatus status)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Dic_Advice>();
                modify[Dic_Advice._.DataStatus] = status;

                DBHelper.Instance.HIS.Update<Dic_Advice>(modify, p => p.Id == entityId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True<AdviceEntity>(null);
            }
            catch (Exception ex)
            {

                return DataResult.Fault<AdviceEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 获取医嘱明细信息(Dic_AdviceFeeItemMapper 表中 Type=1)
        /// </summary>
        /// <param name="entityId">医嘱ID</param>
        /// <returns></returns>
        public List<AdviceFeeItemMapperEntity> GetByAdviceId(long entityId)
        {

            string sql = $@"select a.*,b.Specification as FeeItemSpecification,b.Name as FeeItemName,b.Price as FeeItemPrice from Dic_AdviceFeeItemMapper a
                        left join Dic_FeeItem b on a.FeeItemId = b.Id where  a.Type = @Type and AdviceId = @AdviceId";

            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@Type", System.Data.DbType.String, 1)
                .AddInParameter("@AdviceId", System.Data.DbType.String, entityId).ToList<AdviceFeeItemMapperEntity>();

        }
        /// <summary>
        /// 获取医嘱关联收费信息 (Dic_AdviceFeeItemMapper 表中 Type=2)
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<AdviceFeeItemMapperEntity> GetByAdviceMapperId(long entityId)
        {
            string sql = $@"select a.*,b.Specification as FeeItemSpecification,b.Name as FeeItemName ,b.Price as FeeItemPrice from Dic_AdviceFeeItemMapper a
                        left join Dic_FeeItem b on a.FeeItemId = b.Id where  a.Type = @Type and AdviceId = @AdviceId";

            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@Type", System.Data.DbType.String, 2)
                .AddInParameter("@AdviceId", System.Data.DbType.String, entityId).ToList<AdviceFeeItemMapperEntity>();
        }

        /// <summary>
        /// 新增明细或关联信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<AdviceFeeItemMapperEntity> InsertAdviceFeeItemMapper(AdviceFeeItemMapperEntity entity)
        {
            List<AdviceFeeItemMapperEntity> list = GetByAdviceId(entity.AdviceId);
            list.Add(entity);
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                entity.Id = _idService.CreateUUID();
                var model = entity.Mapper<Dic_AdviceFeeItemMapper>();
                model.SetCreationValues();
                model.Id = entity.Id;
                trans.Insert<Dic_AdviceFeeItemMapper>(model);
                //新增医嘱明细后 需要更新医嘱的价格  关联的收费 则不需要更新医嘱价格
                if (model.Type == 1)
                {
                    UpdateAdvicePrice(entity.AdviceId, list, trans);
                }


                trans.Commit();
                return DataResult.True<AdviceFeeItemMapperEntity>(entity);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<AdviceFeeItemMapperEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }

        /// <summary>
        /// 删除医嘱明细或关联信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<AdviceFeeItemMapperEntity> DeleteAdviceFeeItemMapper(long adviceId, long entityId)
        {

            List<AdviceFeeItemMapperEntity> list = GetByAdviceId(adviceId);

            list.Remove(list.FirstOrDefault(t => t.Id == entityId));

            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                trans.Delete<Dic_AdviceFeeItemMapper>(Dic_AdviceFeeItemMapper._.Id == entityId);
                UpdateAdvicePrice(adviceId, list, trans);

                trans.Commit();
                return DataResult.True<AdviceFeeItemMapperEntity>(null);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<AdviceFeeItemMapperEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }
        private void UpdateAdvicePrice(long adviceId, List<AdviceFeeItemMapperEntity> list, DbTrans trans = null)
        {
            if (list.Count < 1) { return; }//如果没找到医嘱有明细则退出
            double tol = 0;
            foreach (AdviceFeeItemMapperEntity item in list)
            {
                tol += item.FeeItemPrice * item.Quantity;
            }
            HIS.Model.DbAccessor.Choose(trans, DBHelper.Instance.HIS).Update<Dic_Advice>(Dic_Advice._.Price, tol, Dic_Advice._.Id == adviceId);

        }
        /// <summary>
        /// 获取所有医嘱分类
        /// </summary>
        /// <returns></returns>
        public List<AdviceCategoryEntity> GetAdviceCategories()
        {
            var model = DBHelper.Instance.HIS.From<Dic_AdviceCategory>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
            var entities = model.Mapper<List<AdviceCategoryEntity>>();
            var notRootEntities = entities.Where(p => p.Parent.Id != 0);
            foreach (var entity in notRootEntities)
            {
                var parent = entities.Find(p => p.Id == entity.Parent.Id);
                if (parent != null)
                    entity.Parent.Name = parent.Name;
            }

            return entities;
        }
        /// <summary>
        /// 根据分类类型获取医嘱分类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<AdviceCategoryEntity> GetAdviceCategories(AdviceCategoryType type)
        {
            var model = DBHelper.Instance.HIS.From<View_AdviceCategory>().Where(p => p.CategoryType == (int)type && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
            var entities = model.Mapper<List<AdviceCategoryEntity>>();

            var notRootEntities = entities.Where(p => p.Parent.Id != 0);
            foreach (var entity in notRootEntities)
            {
                var parent = entities.Find(p => p.Id == entity.Parent.Id);
                if (parent != null)
                    entity.Parent = parent;
            }

            return entities;
        }
        /// <summary>
        /// 更新医嘱分类
        /// </summary>
        /// <param name="adviceCategory"></param>
        /// <returns></returns>
        public DataResult UpdateAdviceCategory(AdviceCategoryEntity adviceCategory)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Dic_AdviceCategory>();

                modify[Dic_AdviceCategory._.Name] = adviceCategory.Name;
                modify[Dic_AdviceCategory._.ParentId] = adviceCategory.Parent.Id;
                modify[Dic_AdviceCategory._.DeptId] = adviceCategory.Dept?.Id;

                DBHelper.Instance.HIS.Update<Dic_AdviceCategory>(modify, p => p.Id == adviceCategory.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 新增医嘱分类
        /// </summary>
        /// <param name="adviceCategory"></param>
        /// <returns></returns>
        public DataResult AddAdviceCategory(AdviceCategoryEntity adviceCategory)
        {
            try
            {
                var insert = new Dic_AdviceCategory().SetCreationValues();
                adviceCategory.Id = _idService.CreateUUID();
                insert.Id = adviceCategory.Id;
                insert.Name = adviceCategory.Name;
                insert.ParentId = adviceCategory.Parent == null ? 0 : adviceCategory.Parent.Id;
                insert.DeptId = adviceCategory.Dept?.Id;
                insert.CategoryType = (int)adviceCategory.CategoryType;
                insert.No = DBHelper.Instance.HIS.From<Dic_AdviceCategory>().Select(Dic_AdviceCategory._.No.Max()).ToScalar<int>() + 1;

                DBHelper.Instance.HIS.Insert<Dic_AdviceCategory>(insert);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有医嘱和分类映射
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, List<long>> GetAdviceCategoryMapper(int type)
        {
            var mapper = DBHelper.Instance.HIS.From<Dic_AdviceCategoryMapper>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.Type == type).ToList();

            Dictionary<long, List<long>> result = new Dictionary<long, List<long>>();
            var categories = mapper.Select(p => p.CategoryId).Distinct().ToList();
            foreach (var category in categories)
            {
                if (!result.ContainsKey(category))
                    result[category] = new List<long>(mapper.Where(p => p.CategoryId == category).Select(p => p.AdviceId).ToList());
            }

            return result;
        }


        /// <summary>
        /// 插入到分类中
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public DataResult InsertAdviceCategoryMapper(long adviceId, long categoryId, int type)
        {
            try
            {
                var insert = new Dic_AdviceCategoryMapper().SetCreationValues();
                insert.Id = _idService.CreateUUID();
                insert.AdviceId = adviceId;
                insert.CategoryId = categoryId;
                insert.Type = type;
                insert.No = DBHelper.Instance.HIS.From<Dic_AdviceCategoryMapper>().Select(Dic_AdviceCategoryMapper._.No.Max()).Where(p => p.CategoryId == categoryId).ToScalar<int>() + 1;

                DBHelper.Instance.HIS.Insert(insert);
                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 插入到分类中
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public DataResult InsertAdviceCategoryMapper(List<long> adviceIds, long categoryId)
        {
            var maxNo = DBHelper.Instance.HIS.From<Dic_AdviceCategoryMapper>().Select(Dic_AdviceCategoryMapper._.No.Max()).Where(p => p.CategoryId == categoryId).ToScalar<int>() + 1;
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        foreach (var id in adviceIds)
                        {
                            var insert = new Dic_AdviceCategoryMapper().SetCreationValues();
                            insert.Id = _idService.CreateUUID();
                            insert.AdviceId = id;
                            insert.CategoryId = categoryId;
                            insert.No = maxNo++;
                            batch.Insert(insert);
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
        /// 从分类中删除医嘱
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public DataResult DeleteAdviceCategoryMapper(long adviceId, long categoryId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_AdviceCategoryMapper>(p => p.AdviceId == adviceId && p.CategoryId == categoryId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 从分类中删除医嘱
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public DataResult DeleteAdviceCategoryMapper(List<long> adviceIds, long categoryId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_AdviceCategoryMapper>(p => p.AdviceId.In(adviceIds) && p.CategoryId == categoryId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
