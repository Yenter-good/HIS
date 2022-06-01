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

namespace HIS.Service.OP
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-08 14:35:32
    /// 描述:
    /// </summary>
    public class OPBigTemplateService : IOPBigTemplateService
    {
        private readonly IIdService _idService;
        public OPBigTemplateService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取大模板
        /// </summary>
        /// <returns></returns>
        public List<BigTemplateEntity> GetList()
        {
            return DBHelper.Instance.HIS.From<OP_BigTemplate>()
                 .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                     && d.DataStatus == (int)DataStatus.Enable)
                 .Select(OP_BigTemplate._.Id
                       , OP_BigTemplate._.DeptId
                       , OP_BigTemplate._.Name
                       , OP_BigTemplate._.TemplateType
                       , OP_BigTemplate._.EffectiveFlag
                       , OP_BigTemplate._.No
                       , OP_BigTemplate._.WubiCode
                       , OP_BigTemplate._.SearchCode)
                 .ToList<OP_BigTemplate>()
                 .OrderBy(d => d.No)
                 .Mapper<List<BigTemplateEntity>>();
        }
        /// <summary>
        /// 更新生效标识
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="deptId">科室Id</param>
        /// <param name="effectiveFlag">生效标识</param>
        /// <param name="bigTemplateType">模板类型</param>
        /// <returns></returns>
        public DataResult UpdateEffectiveFlag(long id, long deptId, bool effectiveFlag, BigTemplateType bigTemplateType)
        {
            try
            {
                //失效
                if (!effectiveFlag)
                {
                    var modify = AuditionHelper.GetModificationValues<OP_BigTemplate>();
                    modify[OP_BigTemplate._.EffectiveFlag] = effectiveFlag;
                    DBHelper.Instance.HIS.Update<OP_BigTemplate>(modify, d => d.Id == id);

                    return DataResult.True();
                }
                //生效
                string sql = @"update OP_BigTemplate set EffectiveFlag=(case when Id=@Id then 1 else 0 end) 
where HosId=@HosId and DeptId=@DeptId and TemplateType=@TemplateType and DataStatus=@DataStatus";
                DBHelper.Instance.HIS.FromSql(sql)
                    .AddInParameter("@Id", System.Data.DbType.Int64, id)
                    .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                    .AddInParameter("@DeptId", System.Data.DbType.Int64, deptId)
                    .AddInParameter("@TemplateType", System.Data.DbType.Int32, (int)bigTemplateType)
                    .AddInParameter("@DataStatus", System.Data.DbType.Int32, (int)DataStatus.Enable)
                    .ExecuteNonQuery();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            try
            {
                var modify = AuditionHelper.GetDeletionValues<OP_BigTemplate>();
                DBHelper.Instance.HIS.Update<OP_BigTemplate>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 修改模板名称
        /// </summary>
        /// <param name="newName">模板名称</param>
        /// <param name="id">模板Id</param>
        /// <returns></returns>
        public DataResult UpdateName(string newName, long id)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_BigTemplate>();

                modify[OP_BigTemplate._.Name] = newName;
                modify[OP_BigTemplate._.WubiCode] = SpellHelper.GetWuBis(newName);
                modify[OP_BigTemplate._.SearchCode] = SpellHelper.GetSpells(newName);
                DBHelper.Instance.HIS.Update<OP_BigTemplate>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 创建新模板
        /// </summary>
        /// <param name="bigTemplateEntity">大模板实体</param>
        /// <returns></returns>
        public DataResult Add(BigTemplateEntity bigTemplateEntity)
        {
            try
            {
                bigTemplateEntity.Id = this._idService.CreateUUID();
                bigTemplateEntity.No = this.GetNo(bigTemplateEntity.DeptId, bigTemplateEntity.TemplateType);
                if (bigTemplateEntity.DeptId == 0)
                {
                    var exists = DBHelper.Instance.HIS.Exists<OP_BigTemplate>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DeptId == 0 && d.DataStatus == (int)DataStatus.Enable && d.EffectiveFlag == true);
                    if (!exists)
                        bigTemplateEntity.EffectiveFlag = true;
                }
                var model = bigTemplateEntity.Mapper<OP_BigTemplate>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_BigTemplate>(model);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取排序
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="bigTemplateType">大模板类型</param>
        /// <returns></returns>
        public int GetNo(long deptId, BigTemplateType bigTemplateType)
        {
            int maxNo = DBHelper.Instance.HIS.From<OP_BigTemplate>().Where(d => d.DeptId == deptId && d.TemplateType == (int)bigTemplateType)
                .Select(OP_BigTemplate._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 更新模板内容
        /// </summary>
        /// <param name="id">模板Id</param>
        /// <param name="content">模板内容</param>
        /// <returns></returns>
        public DataResult UpdateContent(long id, string content)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_BigTemplate>();
                modify[OP_BigTemplate._.Content] = content;
                DBHelper.Instance.HIS.Update<OP_BigTemplate>(modify, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取模板内容
        /// </summary>
        /// <param name="id">模板Id</param>
        /// <returns></returns>
        public DataResult<string> GetContent(long id)
        {
            try
            {
                string content = DBHelper.Instance.HIS.From<OP_BigTemplate>()
                     .Where(d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                     .Select(OP_BigTemplate._.Content)
                     .ToScalar<string>();
                return DataResult.True<string>(content);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<string>(ex.Message);
            }
        }
    }
}
