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
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-03-05 13:19:31
    /// 描述:
    /// </summary>
    public class OPMedicalRecordService : IOPMedicalRecordService
    {
        /// <summary>
        /// 获取可使用的大模板内容
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <returns></returns>
        public string GetAvailableBigTemplateContent(long deptId, BigTemplateType bigTemplateType)
        {
            string content = null;
            content = DBHelper.Instance.HIS.From<OP_BigTemplate>().Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DeptId == deptId && d.EffectiveFlag == true && d.TemplateType == (int)bigTemplateType)
                .Select(OP_BigTemplate._.Content)
                .ToScalar<string>();
            if (content == null)
                content = DBHelper.Instance.HIS.From<OP_BigTemplate>().Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DeptId == 0 && d.EffectiveFlag == true && d.TemplateType == (int)bigTemplateType)
                .Select(OP_BigTemplate._.Content)
                .ToScalar<string>();

            return content;
        }
        /// <summary>
        /// 获取门诊病历
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        public MedicalRecordEntity GetMedicalRecord(string outPatientNo)
        {
            return DBHelper.Instance.HIS.From<OP_MedicalRecord>()
                   .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.OutpatientNo == outPatientNo && d.DataStatus == (int)DataStatus.Enable)
                   .Select(OP_MedicalRecord._.Id, OP_MedicalRecord._.Content)
                   .First<OP_MedicalRecord>()
                   .Mapper<MedicalRecordEntity>();
        }
    }
}
