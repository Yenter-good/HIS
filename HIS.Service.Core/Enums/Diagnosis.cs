using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 10:59:48
    /// 描述:
    /// </summary>
    public enum DiagnosisType
    {
        [Description("ICD")]
        /// <summary>
        /// ICD
        /// </summary>
        ICD,
        [Description("中医诊断")]
        /// <summary>
        /// 中医诊断
        /// </summary>
        CMDiagnosis,
        [Description("中医症候")]
        /// <summary>
        /// 中医症候
        /// </summary>
        CMSymptoms,
        [Description("自定义诊断")]
        /// <summary>
        /// 自定义诊断
        /// </summary>
        Custom
    }
}
