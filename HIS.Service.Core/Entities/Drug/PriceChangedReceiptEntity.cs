using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 药品调价单据实体类
    /// </summary>
    public class PriceChangedReceiptEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
        public string ReceiptCode { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public UserEntity CreateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public UserEntity AuditUser { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AuditTime { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public bool AuditStatus { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 调价原因
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 计划生效日期
        /// </summary>
        public DateTime PlanEffectTime { get; set; }
        /// <summary>
        /// 实际生效时间
        /// </summary>
        public DateTime? ActualEffectTime { get; set; }

    }
}
