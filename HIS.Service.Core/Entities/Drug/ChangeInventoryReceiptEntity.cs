using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-21 14:51:20
    /// 描述:
    /// </summary>
    public class ChangeInventoryReceiptEntity
    {
        public long Id { get; set; }
        public ChangeInventoryType ReceiptType { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public UserEntity CreateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
        public string ReceiptCode { get; set; }
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
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
    }
}
