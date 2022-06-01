using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class WholehospitalSpecificationEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 药典编码
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 规格编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 药品商品名
        /// </summary>
        public string TradeName { get; set; }
        /// <summary>
        /// 包装数
        /// </summary>
        public int PackageNumber { get; set; }
        /// <summary>
        /// 大包装单位
        /// </summary>
        public string BigPackageUnit { get; set; }
        /// <summary>
        /// 小包装单位
        /// </summary>
        public string SmallPackageUnit { get; set; } 
        /// <summary>
        /// 最下剂量
        /// </summary>
        public float MinDose { get; set; }
        /// <summary>
        /// 最小剂量单位
        /// </summary>
        public string MinDoseUnit { get; set; }
        /// <summary>
        /// DDD值
        /// 也叫限定日剂量
        /// </summary>
        public float DDD { get; set; }
        /// <summary>
        /// DDD规格
        /// </summary>
        public string DDDSpecification { get; set; }
        /// <summary>
        /// 条形码
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 计费方式
        /// </summary>
        public DrugChargeType DrugChargeType { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// 批准文号
        /// </summary>
        public string ApprovalNumber { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 库存上限
        /// </summary>
        public int UpperLimit { get; set; }
        /// <summary>
        /// 库存下限
        /// </summary>
        public int LowerLimit { get; set; }
    }
}
