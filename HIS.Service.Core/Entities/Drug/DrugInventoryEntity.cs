using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core.Entities
{
    [Serializable]
    public class DrugInventoryEntity : DrugEntity
    {
        /// <summary>
        /// 药房库存药品Id
        /// </summary>
        public long InventoryId { get; set; }
        /// <summary>
        /// 进货价
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// 大包装销售价
        /// </summary>
        public decimal BigPackagePrice { get; set; }
        /// <summary>
        /// 小包装销售价
        /// </summary>
        public decimal SmallPackagePrice { get; set; }
        /// <summary>
        /// 大包装库存数
        /// </summary>
        public int BigPackageQuantity { get; set; } 
        /// <summary>
        /// 小包装库存数
        /// </summary>
        public int SmallPackageQuantity { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 医保标识
        /// </summary>
        public string MedicalInsurance { get; set; }
    }
}
