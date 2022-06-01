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
    [XmlInclude(typeof(DrugInventoryEntity))]
    public class DrugEntity
    {
        /// <summary>
        /// 药典编码
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 规格编码
        /// </summary>
        public string SpecificationCode { get; set; }
        /// <summary>
        /// 药品名称
        /// </summary>
        public string DrugName { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>
        public string TradeName { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// 药品属性
        /// </summary>
        public List<LongItem> Properties { get; set; }
        /// <summary>
        /// 定价类型
        /// </summary>
        public LongItem PriceType { get; set; }
        /// <summary>
        /// GMP编码
        /// </summary>
        public string GMP { get; set; }
        /// <summary>
        /// 批准文号
        /// </summary>
        public string ApprovalNumber { get; set; }
        /// <summary>
        /// 药理分类
        /// </summary>
        public LongItem PharmacologyType { get; set; }
        /// <summary>
        /// 处方药类型
        /// </summary>
        public PrescriptionDrugType PrescriptionType { get; set; }
        /// <summary>
        /// 皮试标识
        /// </summary>
        public bool SkinTestFlag { get; set; }
        /// <summary>
        /// 高危标识
        /// </summary>
        public bool DangerFlage { get; set; }
        /// <summary>
        /// 新药标识
        /// </summary>
        public bool NewFlag { get; set; }
        /// <summary>
        /// 抗肿瘤标识
        /// </summary>
        public bool TumorFlag { get; set; }
        /// <summary>
        /// 剂型
        /// </summary>
        public LongItem Drugform { get; set; }
        /// <summary>
        /// 毒麻类型
        /// </summary>
        public bool ToxicType { get; set; }
        /// <summary>
        /// 抗生素等级
        /// </summary>
        public DrugAntibioticType AntibioticType { get; set; }
        /// <summary>
        /// 默认用法
        /// </summary>
        public UsageEntity Usage { get; set; }
        /// <summary>
        /// 发药方式
        /// </summary>
        public LongItem DispensingType { get; set; }
        /// <summary>
        /// 本位码
        /// </summary>
        public string StandardCode { get; set; }
        /// <summary>
        /// 门诊可拆分
        /// </summary>
        public bool OPCanSplit { get; set; }
        /// <summary>
        /// 住院可拆分
        /// </summary>
        public bool IPCanSplit { get; set; }
        /// <summary>
        /// 药品类型
        /// </summary>
        public ItemType ItemType { get; set; }
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
        /// 最小剂量
        /// </summary>
        public float MinDose { get; set; }
        /// <summary>
        /// 最小计量单位
        /// </summary>
        public string MinDoseUnit { get; set; }
        /// <summary>
        /// DDD
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
        public DrugChargeType ChargeType { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
    }
}
