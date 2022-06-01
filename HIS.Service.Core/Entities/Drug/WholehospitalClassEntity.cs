using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 全院药品品种
    /// </summary>
    public class WholehospitalClassEntity
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
        /// 排序
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 药典编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 药典名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 药品属性
        /// </summary>
        public List<LongItem> Property { get; set; }
        /// <summary>
        /// 定价类型
        /// </summary>
        public LongItem PriceType { get; set; }
        /// <summary>
        /// GMP
        /// </summary>
        public string GMP { get; set; }
        /// <summary>
        /// 药理分类
        /// </summary>
        public LongItem PharmacologyType { get; set; }
        /// <summary>
        /// 处方药标志
        /// </summary>
        public PrescriptionDrugType PrescriptionType { get; set; }
        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool SkinTestFlag { get; set; }
        /// <summary>
        /// 高危标志
        /// </summary>
        public bool DangerFlage { get; set; }
        /// <summary>
        /// 新药标志
        /// </summary>
        public bool NewFlag { get; set; }
        /// <summary>
        /// 抗肿瘤标志
        /// </summary>
        public bool TumorFlag { get; set; }
        /// <summary>
        /// 基药标识
        /// </summary>
        public bool BasicDrugFlag { get; set; }
        /// <summary>
        /// 药品剂型
        /// </summary>
        public LongItem Drugfrom { get; set; }
        /// <summary>
        /// 精神毒麻类型
        /// </summary>
        public DrugToxicType ToxicType { get; set; }
        /// <summary>
        /// 抗生素级别
        /// </summary>
        public DrugAntibioticType AntibioticType { get; set; }
        /// <summary>
        /// 用药途径
        /// </summary>
        public UsageEntity UseWay { get; set; }
        /// <summary>
        /// 发药方式
        /// </summary>
        public LongItem DispensingType { get; set; }
        /// <summary>
        /// 药品本位码
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
        public DrugType DrugType { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
    }
}
