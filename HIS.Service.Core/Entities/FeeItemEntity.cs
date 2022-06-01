using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class FeeItemEntity
    {
        /// <summary>
        /// 门诊划价启用标识
        /// </summary>
        public bool OFlag { get; set; } 
        /// <summary>
        /// 住院划价启用标识
        /// </summary>
        public bool IFlag { get; set; }
        /// <summary>
        /// 手术划价启用标识
        /// </summary>
        public bool SFlag { get; set; }
        /// <summary>
        /// 医技划价启用标识
        /// </summary>
        public bool MFlag { get; set; }
        /// <summary>
        /// 价格是否允许调整
        /// </summary>
        public bool VariableFlag { get; set; }
        /// <summary>
        /// 唯一标识
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 最小计量
        /// </summary>
        public float Measure { get; set; }
        /// <summary>
        /// 最小计量单位
        /// </summary>
        public string MeasureUnit { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 财务分类编码
        /// </summary>
        public string FinanceTypeCode { get; set; }
        /// <summary>
        /// 默认执行科室ID
        /// </summary>
        public long ExecDeptId { get; set; }
    }
}
