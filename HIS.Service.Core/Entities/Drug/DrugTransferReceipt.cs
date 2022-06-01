using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-23 15:47:23
    /// 描述:
    /// </summary>
    public class DrugTransferReceipt
    {
        public long Id { get; set; }
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
        /// 源头发出科室
        /// </summary>
        public DeptEntity ApplyDept { get; set; }
        /// <summary>
        /// 目标接受科室
        /// </summary>
        public DeptEntity AcceptDept { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
    }
}
