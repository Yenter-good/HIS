using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 10:57:16
    /// 描述:
    /// </summary>
    public class PatientDiagnosisEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public UserEntity CreatorUser { get; set; }
        /// <summary>
        /// 前缀
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// 诊断
        /// </summary>
        public DiagnosisEntity Diagnosis { get; set; }
        /// <summary>
        /// 后缀
        /// </summary>
        public string Postfix { get; set; }
        /// <summary>
        /// 是否确诊
        /// </summary>
        public bool ConfirmFlag { get; set; }
        /// <summary>
        /// 是否主诊断
        /// </summary>
        public bool MainFlag { get; set; }
    }
}
