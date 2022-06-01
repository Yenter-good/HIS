using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-02 14:43:39
    /// 描述:
    /// </summary>
    public interface IOPJournalService : IServiceSingleton
    {
        /// <summary>
        /// 添加门诊日志
        /// </summary>
        /// <param name="patientJournalEntity"></param>
        /// <returns></returns>
        DataResult AddJournal(OutpatientEntity outpatientEntity);
        /// <summary>
        /// 根据门诊号判断门诊日志是否存在
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        bool JournalExists(string outPatientNo);
        /// <summary>
        /// 根据门诊号判断门诊日志是否有效
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        bool JournalEffective(string outPatientNo);
        /// <summary>
        /// 根据门诊号获取门诊日志
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        PatientJournalEntity GetJournal(string outPatientNo);
        /// <summary>
        /// 更新门诊日志
        /// </summary>
        /// <param name="outpatientEntity"></param>
        /// <returns></returns>
        DataResult UpdateJournal(PatientJournalEntity patientJournalEntity);
        /// <summary>
        /// 患者初复诊
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        int FirstOrSecond(string outPatientNo);
    }
}
