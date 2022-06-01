using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class PriceChangedDeptInfluenceEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; } 
        /// <summary>
        /// 受影响的大包装数量
        /// </summary>
        public int BigPackageQuantity { get; set; }
        /// <summary>
        /// 受影响的小包装数量
        /// </summary>
        public int SmallPackageQuantity { get; set; }
        /// <summary>
        /// 受影响的大包装总价
        /// </summary>
        public decimal BigPackageTotal { get; set; }
        /// <summary>
        /// 受影响的小包装总价
        /// </summary>
        public decimal SmallPackageTotal { get; set; }
    }
}
