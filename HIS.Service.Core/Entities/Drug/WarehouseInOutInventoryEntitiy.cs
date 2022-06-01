using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core.Entities
{
    [Serializable]
    /// <summary>
    /// 药库入出库单据实体
    /// </summary>
    public class WarehouseInOutInventoryReceiptEntitiy
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
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 供货商
        /// </summary>
        public string SupplyUnit { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string InvoiceNo { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; }

    }
}
