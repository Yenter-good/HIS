using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 处方药类型
    /// </summary>
    public enum PrescriptionDrugType
    {
        [Description("处方药")]
        处方药,
        [Description("非处方药(甲类)")]
        非处方药I,
        [Description("非处方药(乙类)")]
        非处方药II,
        [Description("非药品")]
        非药品,
    }
    /// <summary>
    /// 毒麻标志
    /// </summary>
    public enum DrugToxicType
    {
        否,
        普通,
        精一,
        精二,
        麻醉
    }
    public enum DrugAntibioticType
    {
        非抗生素,
        非限制,
        限制使用,
        特殊使用
    }
    /// <summary>
    /// 药品类型
    /// </summary>
    public enum DrugType
    {
        西药,
        中成药,
        草药,
        颗粒剂
    }
    public enum DrugChargeType
    {
        按次取整,
        按量取整
    }
    /// <summary>
    /// 药品生产厂商类型
    /// </summary>
    public enum MerchantType
    {
        生产厂家 = 1,
        供应厂商 = 2
    }
    /// <summary>
    /// 药品分类
    /// </summary>
    [Flags]
    public enum DrugCategory
    {
        普通 = 0,
        慢性病 = 1 << 0,
        麻醉 = 1 << 1,
        精一 = 1 << 2,
        精二 = 1 << 3
    }
}
