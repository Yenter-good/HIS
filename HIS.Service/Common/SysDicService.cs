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
    public class SysDicService : ISysDicService
    {
        private IIdService idService;
        private ISysDicDetailService _sysDicDetailService;

        public SysDicService(IIdService idService, ISysDicDetailService sysDicDetailService)
        {
            this.idService = idService;
            this._sysDicDetailService = sysDicDetailService;
        }

        /// <summary>
        /// 获取系统字典
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<SysDicEntity> GetList(bool includeDisable = false)
        {
            if (includeDisable)
                return AutoMapperHelper.Instance.Mapper.Map<List<SysDicEntity>>(DBHelper.Instance.HIS.From<Sys_Dic>().Where(d => d.DataStatus != (int)DataStatus.Delete && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(o => o.No).ToList());
            return AutoMapperHelper.Instance.Mapper.Map<List<SysDicEntity>>(DBHelper.Instance.HIS.From<Sys_Dic>().Where(d => d.DataStatus == (int)DataStatus.Enable && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(o => o.No).ToList());
        }
        /// <summary>
        /// 获取字典类型信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public SysDicEntity GetByCode(string code)
        {
            return AutoMapperHelper.Instance.Mapper.Map<SysDicEntity>(DBHelper.Instance.HIS.From<Sys_Dic>().Where(d => d.Code == code && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First());
        }

        [CacheMethod(CachingMethod.Get, Key = HIS.Core.Cache.CacheKeys.ISysDicService_GetListByDicCode)]
        public List<ItemEntity> GetList(string dictType)
        {
            dictType.CheckNotNullOrEmpty(nameof(dictType));
            var model = DBHelper.Instance.HIS.From<Sys_Dic>().Where(d => d.Code == dictType && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First();

            if (model.DataStatus == (int)DataStatus.Delete || model.DataStatus == (int)DataStatus.Disable) return new List<ItemEntity>();
            return AutoMapperHelper.Instance.Mapper.Map<List<ItemEntity>>(_sysDicDetailService.GetListByDicCode(dictType));
        }
        /// <summary>
        /// 字典编码是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>

        public bool CodeExists(string code)
        {
            bool codeExists = DBHelper.Instance.HIS.Exists<Sys_Dic>(d => d.Code == code && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete);

            return codeExists;
        }
        /// <summary>
        /// 获取排序值
        /// </summary>
        /// <param name="catalogId">所属目录Id</param>
        /// <returns></returns>
        public int GetNo(long catalogId)
        {
            int maxNo = DBHelper.Instance.HIS.From<Sys_Dic>()
                .Where(d => d.CatalogId == catalogId && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                .Select(Sys_Dic._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 添加字典
        /// </summary>
        /// <param name="sysDicEntity">字典实体</param>
        /// <returns></returns>
        public DataResult Add(SysDicEntity sysDicEntity)
        {
            try
            {
                Sys_Dic sysDic = sysDicEntity.Mapper<Sys_Dic>();
                sysDic.SetCreationValues();

                sysDic.Id = idService.CreateUUID();
                sysDic.CatalogId = sysDicEntity.CatalogId;
                sysDic.Code = sysDicEntity.Code;
                sysDic.Name = sysDicEntity.Name;
                sysDic.Description = sysDicEntity.Description;
                sysDic.SearchCode = sysDicEntity.SearchCode;
                sysDic.No = sysDicEntity.No;
                sysDic.DataStatus = (int)sysDicEntity.DataStatus;

                DBHelper.Instance.HIS.Insert<Sys_Dic>(sysDic);

                return DataResult.True();
            }
            catch (Exception ex)
            {

                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 获取字典
        /// </summary>
        /// <returns></returns>
        public DataResult<List<SysDicEntity>> GetAll()
        {
            try
            {
                List<SysDicEntity> sysDicEntitys = DBHelper.Instance.HIS.From<Sys_Dic>()
                     .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete)
                     .OrderBy(d => d.No)
                     .ToList<Sys_Dic>()
                     .Mapper<List<SysDicEntity>>();

                return DataResult.True<List<SysDicEntity>>(sysDicEntitys);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<SysDicEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 修改字典名称
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="name">字典名称</param>
        /// <returns></returns>
        public DataResult UpdateNameById(long id, string name)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_Dic>();
                updateValue[Sys_Dic._.Name] = name;
                DBHelper.Instance.HIS.Update<Sys_Dic>(updateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 修改字典
        /// </summary>
        /// <param name="sysDicEntity">字典实体</param>
        /// <returns></returns>
        public DataResult Update(SysDicEntity sysDicEntity)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_Dic>();
                updateValue[Sys_Dic._.Name] = sysDicEntity.Name;
                updateValue[Sys_Dic._.Description] = sysDicEntity.Description;
                updateValue[Sys_Dic._.SearchCode] = sysDicEntity.SearchCode;
                updateValue[Sys_Dic._.DataStatus] = sysDicEntity.DataStatus.AsBoolean();
                updateValue[Sys_Dic._.IsBuiltIn] = sysDicEntity.IsBuiltIn;

                DBHelper.Instance.HIS.Update<Sys_Dic>(updateValue, d => d.Id == sysDicEntity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="code">字典编码</param>
        /// <returns></returns>
        public DataResult Delete(long id, string code)
        {
            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                Dictionary<Dos.ORM.Field, object> dicUpdateValue = AuditionHelper.GetDeletionValues<Sys_Dic>();
                Dictionary<Dos.ORM.Field, object> dicDetailUpdateValue = AuditionHelper.GetDeletionValues<Sys_Dic_Details>();

                tran.Update<Sys_Dic>(dicUpdateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                tran.Update<Sys_Dic_Details>(dicDetailUpdateValue, d => d.DicCode == code && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                tran.Commit();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return DataResult.Fault(ex.Message);
            }
            finally
            {
                if (tran != null)
                    tran.Close();
            }
        }
        /// <summary>
        /// 更新字典状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="code">字典编码</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        public DataResult UpdateDataStatus(long id, string code, DataStatus dataStatus)
        {
            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                Dictionary<Dos.ORM.Field, object> dicUpdateValue = AuditionHelper.GetModificationValues<Sys_Dic>();
                dicUpdateValue[Sys_Dic._.DataStatus] = (int)dataStatus;

                Dictionary<Dos.ORM.Field, object> dicDetailUpdateValue = AuditionHelper.GetModificationValues<Sys_Dic_Details>();
                dicDetailUpdateValue[Sys_Dic_Details._.DataStatus] = (int)dataStatus;

                tran.Update<Sys_Dic>(dicUpdateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                tran.Update<Sys_Dic_Details>(dicDetailUpdateValue, d => d.DicCode == code && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete);

                tran.Commit();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return DataResult.Fault(ex.Message);
            }
            finally
            {
                if (tran != null)
                    tran.Close();
            }
        }

    }
}
