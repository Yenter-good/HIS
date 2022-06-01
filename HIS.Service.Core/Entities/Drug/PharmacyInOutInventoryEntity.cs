using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class PharmacyInOutInventoryEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 单据编码
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
        /// 单据类型
        /// </summary>
        public PharmacyInOutReceiptType ReceiptType { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 源头发出科室
        /// </summary>
        public DeptEntity SourceDept { get; set; }
        /// <summary>
        /// 目标接收科室
        /// </summary>
        public DeptEntity TargetDept { get; set; }
    }
}
