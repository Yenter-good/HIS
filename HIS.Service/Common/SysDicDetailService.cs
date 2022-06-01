using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;
using HIS.Utility;

namespace HIS.Service
{
    public class SysDicDetailService : ISysDicDetailService
    {
        private readonly IIdService _idService;

        public SysDicDetailService(IIdService idService)
        {
            this._idService = idService;
        }


        /// <summary>
        /// 根据字典编码获取明细
        /// </summary>
        /// <param name="dicCode"></param>
        /// <param name="includeDisable">是否包含停用的</param>
        /// <returns></returns>
        public List<SysDicDetailEntity> GetListByDicCode(string dicCode, bool includeDisable = false)
        {
            if (dicCode == null)
                return null;
            if (includeDisable)
                return AutoMapperHelper.Instance.Mapper.Map<List<SysDicDetailEntity>>(DBHelper.Instance.HIS.From<Sys_Dic_Details>().Where(d => d.DicCode == dicCode && d.DataStatus != (int)DataStatus.Delete && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(o => o.No).ToList());

            return AutoMapperHelper.Instance.Mapper.Map<List<SysDicDetailEntity>>(DBHelper.Instance.HIS.From<Sys_Dic_Details>().Where(d => d.DataStatus == (int)DataStatus.Enable && d.DicCode == dicCode && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(o => o.No).ToList());
        }
        /// <summary>
        /// 是否存在内置字典明细
        /// </summary>
        /// <param name="dicCode">字典编码</param>
        /// <returns></returns>
        public bool BuiltInDicDetailExists(string dicCode)
        {
            bool builtInDicDetailExists = DBHelper.Instance.HIS.Exists<Sys_Dic_Details>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
            && d.DicCode == dicCode && d.DataStatus != (int)DataStatus.Delete);

            return builtInDicDetailExists;
        }
        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult Add(SysDicDetailEntity entity)
        {
            try
            {
                var insert = entity.Mapper<Sys_Dic_Details>().SetCreationValues();

                entity.Id = _idService.CreateUUID();
                insert.Id = entity.Id;
                insert.DataStatus = (int)entity.DataStatus;
                insert.No = DBHelper.Instance.HIS.From<Sys_Dic_Details>().Where(p => p.DicCode == entity.DicCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(Sys_Dic_Details._.No.Max()).ToScalar<int>() + 1;

                DBHelper.Instance.HIS.Insert(insert);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult Update(SysDicDetailEntity entity)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_Dic_Details>();

                modify[Sys_Dic_Details._.Value] = entity.Value;
                modify[Sys_Dic_Details._.Description] = entity.Description;
                modify[Sys_Dic_Details._.IsBuiltIn] = entity.IsBuiltIn;
                modify[Sys_Dic_Details._.Extensibility] = entity.Extensibility;
                modify[Sys_Dic_Details._.DataStatus] = entity.DataStatus.AsBoolean();

                DBHelper.Instance.HIS.Update<Sys_Dic_Details>(modify, p => p.Id == entity.Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="Id">唯一标识</param>
        /// <returns></returns>
        public DataResult Delete(long Id)
        {
            try
            {
                var isBuildIn = DBHelper.Instance.HIS.Exists<Sys_Dic_Details>(p => p.Id == Id && p.IsBuiltIn == true && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                if (isBuildIn)
                {
                    return DataResult.Fault("当前编码为内置编码，无法删除");
                }

                var delete = AuditionHelper.GetDeletionValues<Sys_Dic_Details>();
                DBHelper.Instance.HIS.Update<Sys_Dic_Details>(delete, p => p.Id == Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除全部明细
        /// </summary>
        /// <param name="dicCode">字典编码</param>
        /// <returns></returns>
        public DataResult DeleteAll(string dicCode)
        {
            try
            {
                var delete = AuditionHelper.GetDeletionValues<Sys_Dic_Details>();
                DBHelper.Instance.HIS.Update<Sys_Dic_Details>(delete, p => p.DataStatus != (int)DataStatus.Delete && p.IsBuiltIn == false && p.DicCode == dicCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 编码是否存在
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="dicCode">所属字典编码</param>
        /// <returns></returns>
        public bool ExistCode(string code, string dicCode)
        {
            return DBHelper.Instance.HIS.Exists<Sys_Dic_Details>(p => p.DataStatus != (int)DataStatus.Delete && p.Code == code && p.DicCode == dicCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
        }
    }
}
