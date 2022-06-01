using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-13 14:57:47
    /// 描述:药房申请单据明细
    /// </summary>
    public class PharmacyInOutInventoryDetailEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 药品
        /// </summary>
        public DrugEntity Drug { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 单据价格
        /// </summary>
        public decimal ReceiptPrice { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 剩余库存数
        /// </summary>
        public int Inventory { get; set; }
        /// <summary>
        /// 进货价
        /// </summary>
        public decimal PurchasePrice { get; set; }
    }
}
