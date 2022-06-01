using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    [Serializable]
    /// <summary>
    /// 药库入出库单据明细实体
    /// </summary>
    public class WarehouseInOutInventoryReceiptDetailEntitiy
    {
        public long Id { get; set; }
        /// <summary>
        /// 单据ID
        /// </summary>
        public long ReceiptId { get; set; }
        /// <summary>
        /// 药品
        /// </summary>
        public DrugEntity Drug { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 进货价
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// 单据价格
        /// </summary>
        public decimal ReceiptPrice { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNumber { get; set; }
        /// <summary>
        /// 批准文号
        /// </summary>
        public string ApprovalNumber { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }
}
