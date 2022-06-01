using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities.Drug
{
    public class ProcurementPlanDetailEntity
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
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 生产厂家
        /// </summary>
        public String Manufacturer { get; set; }

        /// <summary>
        /// 剂型名称
        /// </summary>
        public String DrugformValue { get; set; }

        /// <summary>
        /// 包装单位
        /// </summary>
        public String BigPackageUnit { get; set; }
        /// <summary>
        /// 西药库库存
        /// </summary>
        public int Inventory { get; set; }
        /// <summary>
        /// 门诊药房库存
        /// </summary>
        public int OPInventory { get; set; }
        /// <summary>
        /// 急诊药房库存
        /// </summary>
        public int EmergencyInventory { get; set; }
        /// <summary>
        /// 住院药房库存
        /// </summary>
        public int IPInventory { get; set; }
    }
}
