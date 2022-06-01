using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 药品调价单据明细表
    /// </summary>
    public class PriceChangedReceiptDetailEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 单据Id
        /// </summary>
        public long ReceiptId { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 药品
        /// </summary>
        public DrugEntity Drug { get; set; }
        /// <summary>
        /// 调价前临售价
        /// </summary>
        public decimal OldPrice { get; set; }
        /// <summary>
        /// 售价实时价
        /// </summary>
        public decimal RealTimePrice { get; set; }
        /// <summary>
        /// 调价后临售价
        /// </summary>
        public decimal NewPrice { get; set; }
        /// <summary>
        /// 调价前后的差价
        /// </summary>
        public decimal PriceDifference { get; set; }

    }
}
