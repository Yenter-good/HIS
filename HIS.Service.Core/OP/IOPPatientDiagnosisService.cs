using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 11:01:43
    /// 描述:
    /// </summary>
    public interface IOPPatientDiagnosisService : IServiceSingleton
    {
        /// <summary>
        /// 获取指定门诊号的诊断
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <returns></returns>
        List<PatientDiagnosisEntity> Get(string outpatientNo);
        /// <summary>
        /// 更新主诊断标识
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        DataResult UpdateMainFlag(long Id, string outpatientNo);
        /// <summary>
        /// 更新确诊标识
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        DataResult UpdateConfirmFlag(long Id, bool value);
        /// <summary>
        /// 更新前缀
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        DataResult UpdatePrefix(long Id, string value);
        /// <summary>
        /// 更新后缀
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        DataResult UpdatePostfix(long Id, string value);
        /// <summary>
        /// 获取指定科室的常用诊断
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DiagnosisEntity> GetDiagnosisGroup(long deptId);
        /// <summary>
        /// 增加诊断
        /// </summary>
        /// <param name="diagnosisEntity"></param>
        /// <returns></returns>
        DataResult<long> AddDiagnosis(PatientDiagnosisEntity diagnosisEntity, string outpatientNo, long deptId);
        /// <summary>
        /// 修改诊断
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="diagnosisEntity"></param>
        /// <returns></returns>
        DataResult UpdateDiagnosis(long Id, DiagnosisEntity diagnosisEntity);
        /// <summary>
        /// 删除诊断
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        DataResult DeleteDiagnosis(long Id);
    }
}
