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
    public class PrescriptionDrugEntity : DrugEntity
    {
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
        public DeptEntity ExecDept { get; set; }
        /// <summary>
        /// 医保标识
        /// </summary>
        public string MedicalInsurance { get; set; }
        /// <summary>
        /// 间隔
        /// </summary>
        public IntervalEntity Interval { get; set; }
        /// <summary>
        /// 皮试标志
        /// </summary>
        public SkinTestFlag PatientSkinTestFlag { get; set; }
        /// <summary>
        /// 用药数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 一次用量
        /// </summary>
        public float Dose { get; set; }
        /// <summary>
        /// 同组编号
        /// </summary>
        public int GroupNo { get; set; }
        /// <summary>
        /// 是否大包装
        /// </summary>
        public bool BigPackageFlag { get; set; }
        /// <summary>
        /// 是否自定义价格
        /// </summary>
        public bool CustomPriceFlag { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Remark { get; set; }
    }
}
