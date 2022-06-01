using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_OP
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-01 10:57:59
    /// 描述:
    /// </summary>
    internal enum DataModifyType
    {
        /// <summary>
        /// 诊断变更
        /// </summary>
        DiagnosisChanged,
        /// <summary>
        /// 主诊断变更
        /// </summary>
        MainDiagnosisChanged,
        /// <summary>
        /// 选中处方
        /// </summary>
        SelectPrescription,
        /// <summary>
        /// 召回处方
        /// </summary>
        UndoPrescription,
        /// <summary>
        /// 保存处方
        /// </summary>
        SavePrescription,
        /// <summary>
        /// 患者信息变更
        /// </summary>
        PatientInfoChanged,
    }
    /// <summary>
    /// 
    /// </summary>
    internal enum RegisterDataType
    {
        GetAllDiagnosis,
        /// <summary>
        /// 获取病史摘要
        /// </summary>
        GetConditionSummary,
    }
}
