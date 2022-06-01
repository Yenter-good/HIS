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
    /// 创建时间:2021-01-28 15:32:00
    /// 描述:
    /// </summary>
    public class DiagnosisEntity
    {
        /// <summary>
        /// 诊断编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 诊断名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 诊断长度
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// 诊断类型
        /// </summary>
        public DiagnosisType Type { get; set; }
    }
}
