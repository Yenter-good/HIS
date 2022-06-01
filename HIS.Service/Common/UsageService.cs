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
    public class UsageService : IUsageService
    {
        private readonly IIdService _idService;

        public UsageService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取所有用法
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<UsageEntity> GetAll(bool includeDisable = false)
        {
            List<Dic_Usage> models;
            if (includeDisable)
                models = DBHelper.Instance.HIS.From<Dic_Usage>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(new Dos.ORM.Field[] { Dic_Usage._.Category, Dic_Usage._.No }).ToList();
            else
                models = DBHelper.Instance.HIS.From<Dic_Usage>().Where(p => p.DataStatus == (int)DataStatus.Enable && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(new Dos.ORM.Field[] { Dic_Usage._.Category, Dic_Usage._.No }).ToList();

            return models.Mapper<List<UsageEntity>>();
        }
        /// <summary>
        /// 获取所有用法字典,0西药,1中药
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<UsageEntity> GetAll(int category)
        {
            var models = DBHelper.Instance.HIS.From<Dic_Usage>().Where(p => p.DataStatus == (int)DataStatus.Enable && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.Category == category).OrderBy(Dic_Usage._.Category, Dic_Usage._.No).ToList();

            return models.Mapper<List<UsageEntity>>();
        }
        /// <summary>
        /// 获取指定id的用法
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public UsageEntity Get(long usageId)
        {
            return DBHelper.Instance.HIS.From<Dic_Usage>().Where(p => p.Id == usageId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<UsageEntity>();
        }
        /// <summary>
        /// 获取指定编码的用法
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public UsageEntity Get(string usageCode)
        {
            return DBHelper.Instance.HIS.From<Dic_Usage>().Where(p => p.Code == usageCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<UsageEntity>();
        }
        /// <summary>
        /// 更新用法
        /// </summary>
        /// <param name="usageEntity"></param>
        /// <returns></returns>
        public DataResult Update(UsageEntity usageEntity)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Dic_Usage>();

                modify[Dic_Usage._.Name] = usageEntity.Name;
                modify[Dic_Usage._.SearchCode] = usageEntity.SearchCode;
                modify[Dic_Usage._.WubiCode] = usageEntity.WubiCode;
                modify[Dic_Usage._.Category] = (int)usageEntity.Category;
                modify[Dic_Usage._.Code] = usageEntity.Code;
                modify[Dic_Usage._.No] = usageEntity.No;

                DBHelper.Instance.HIS.Update<Dic_Usage>(modify, p => p.Id == usageEntity.Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 插入用法
        /// </summary>
        /// <param name="usageEntity"></param>
        /// <returns></returns>
        public DataResult Insert(UsageEntity usageEntity)
        {
            try
            {
                usageEntity.DataStatus = DataStatus.Enable;
                var insert = usageEntity.Mapper<Dic_Usage>();
                usageEntity.Id = _idService.CreateUUID();
                insert.SetCreationValues();
                insert.Id = usageEntity.Id;

                DBHelper.Instance.HIS.Insert(insert);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 是否有重复code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ExistCode(string code)
        {
            return DBHelper.Instance.HIS.Exists<Dic_Usage>(p => p.Code == code && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
        }
        /// <summary>
        /// 启用指定用法
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataResult EnableUsage(long Id)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Dic_Usage>();
                modify[Dic_Usage._.DataStatus] = (int)DataStatus.Enable;

                DBHelper.Instance.HIS.Update<Dic_Usage>(modify, p => p.Id == Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 停用指定用法
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataResult DisableUsage(long Id)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Dic_Usage>();
                modify[Dic_Usage._.DataStatus] = (int)DataStatus.Disable;

                DBHelper.Instance.HIS.Update<Dic_Usage>(modify, p => p.Id == Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定剂型下的默认用法
        /// </summary>
        /// <param name="drugformId"></param>
        /// <returns></returns>
        public UsageEntity GetDrugformDefault(long drugformId)
        {
            var usageId = DBHelper.Instance.HIS.From<Dic_DrugformUsageMapper>().Where(p => p.DrugformId == drugformId && p.IsDefault == true && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(p => p.UsageId).ToScalar<long?>();
            if (usageId == null)
                return null;

            return this.Get(usageId.Value);
        }
        /// <summary>
        /// 获取所有剂型和用法的对应关系
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, List<UsageEntity>> GetAllDrugformUsageMapper()
        {
            var models = DBHelper.Instance.HIS.From<Dic_DrugformUsageMapper>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(p => new { p.DrugformId, p.UsageId, p.IsDefault }).ToList();

            Dictionary<long, List<UsageEntity>> result = new Dictionary<long, List<UsageEntity>>();

            var drugformIds = models.Select(p => p.DrugformId).Distinct().ToList();
            foreach (var drugformId in drugformIds)
            {
                if (!result.ContainsKey(drugformId))
                    result[drugformId] = new List<UsageEntity>();
                result[drugformId].AddRange(models.Where(p => p.DrugformId == drugformId).Select(p => new UsageEntity() { Id = p.UsageId, IsDefault = p.IsDefault }).ToList());
            }

            return result;
        }
        /// <summary>
        /// 获取指定剂型下的所有用法ID
        /// </summary>
        /// <param name="drugformId"></param>
        /// <returns></returns>
        public List<UsageEntity> GetDrugformUsageMapper(long drugformId)
        {
            var models = DBHelper.Instance.HIS.From<Dic_DrugformUsageMapper>().Where(p => p.DrugformId == drugformId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(p => new { p.DrugformId, p.UsageId, p.IsDefault }).ToList();

            return models.Select(p => new UsageEntity() { Id = p.UsageId, IsDefault = p.IsDefault }).ToList();
        }
        /// <summary>
        /// 将指定用法添加到指定剂型下
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public DataResult AddToDrugform(long drugformId, long usageId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    var insert = new Dic_DrugformUsageMapper();
                    insert.DrugformId = drugformId;
                    insert.UsageId = usageId;
                    insert.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                    insert.IsDefault = false;

                    tran.Delete<Dic_DrugformUsageMapper>(p => p.DrugformId == drugformId && p.UsageId == usageId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                    tran.Insert(insert);

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
        /// 将一组用法添加到指定剂型下
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageIds"></param>
        /// <returns></returns>
        public DataResult AddToDrugform(long drugformId, List<long> usageIds)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    tran.Delete<Dic_DrugformUsageMapper>(p => p.DrugformId == drugformId && p.UsageId.In(usageIds) && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        foreach (var usageId in usageIds)
                        {
                            var insert = new Dic_DrugformUsageMapper().SetCreationValues();
                            insert.DrugformId = drugformId;
                            insert.UsageId = usageId;
                            insert.IsDefault = false;

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
        /// 将指定用法从指定剂型下删除
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public DataResult DeleteFromDrugform(long drugformId, long usageId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_DrugformUsageMapper>(p => p.DrugformId == drugformId && p.UsageId == usageId);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 将一组用法从指定剂型下删除
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageIds"></param>
        /// <returns></returns>
        public DataResult DeleteFromDrugform(long drugformId, List<long> usageIds)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_DrugformUsageMapper>(p => p.DrugformId == drugformId && p.UsageId.In(usageIds));
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 将指定剂型下的指定用法设为默认,并将同剂型下的其他用法设为不默认
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public DataResult SetDefault(long drugformId, long usageId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    Dictionary<Field, object> modify = new Dictionary<Field, object>();

                    modify[Dic_DrugformUsageMapper._.IsDefault] = false;
                    tran.Update<Dic_DrugformUsageMapper>(modify, p => p.DrugformId == drugformId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                    modify[Dic_DrugformUsageMapper._.IsDefault] = true;
                    tran.Update<Dic_DrugformUsageMapper>(modify, p => p.DrugformId == drugformId && p.UsageId == usageId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

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
    }
}
