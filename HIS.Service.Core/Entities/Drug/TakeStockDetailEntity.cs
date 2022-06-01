using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities.Drug
{
    public class TakeStockDetailEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public String ReceiptCode { get; set; }
        /// <summary>
        /// 品种编码
        /// </summary>
        public String ClassCode { get; set; }
        /// <summary>
        /// 规格编码
        /// </summary>
        public String SpecificationCode { get; set; }
        /// <summary>
        /// 药品名称
        /// </summary>
        public String DrugName { get; set; }
        /// <summary>
        ///规格
        /// </summary>
        public String Specification { get; set; }

        /// <summary>
        /// 生产厂家
        /// </summary>
        public String Manufacturer { get; set; }

        /// <summary>
        /// 剂型名称
        /// </summary>
        public String DrugformValue { get; set; }

        /// <summary>
        /// 大包装单位
        /// </summary>
        public String BigPackageUnit { get; set; }

        /// <summary>
        /// 小包装单位
        /// </summary>
        public String SmallPackageUnit { get; set; }
        /// <summary>
        /// 盘点前大包装库存数量
        /// </summary>
        public int CurrentBigQuantity { get; set; }
        /// <summary>
        /// 盘点后大包装实际库存数量
        /// </summary>
        public int ActualBigQuantity { get; set; }
        /// <summary>
        /// 盘点前小包装库存数量
        /// </summary>
        public int CurrentSmallQuantity { get; set; }
        /// <summary>
        /// 盘点后小包装实际库存数量
        /// </summary>
        public int ActualSmallQuantity { get; set; }
        /// <summary>
        /// 盘点后大包装盈亏数量
        /// </summary>
        public int ProfitLossBigQuantity { get; set; }

        /// <summary>
        /// 盘点后小包装盈亏数量
        /// </summary>
        public int ProfitLossSmallQuantity { get; set; }

        /// <summary>
        /// 盘点后大包装盈亏金额
        /// </summary>
        public decimal ProfitLossBigPrice { get; set; }
        /// <summary>
        /// 盘点后小包装盈亏金额
        /// </summary>
        public decimal ProfitLossSmallPrice { get; set; }
    }
}
