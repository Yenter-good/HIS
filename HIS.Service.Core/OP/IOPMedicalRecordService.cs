using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-03-05 13:15:36
    /// 描述:
    /// </summary>
    public interface IOPMedicalRecordService : IServiceSingleton
    {
        /// <summary>
        /// 获取可使用的大模板内容
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="bigTemplateType">大模板类型</param>
        /// <returns></returns>
        string GetAvailableBigTemplateContent(long deptId, BigTemplateType bigTemplateType);
        /// <summary>
        /// 获取病历内容
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        MedicalRecordEntity GetMedicalRecord(string outPatientNo);
    }
}
