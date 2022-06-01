using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-13 16:33:38
    /// 描述:
    /// </summary>
    [Flags]
    public enum DeptCategoryDetail
    {
        [Description("")]
        None = 0,
        /// <summary>
        /// 西药房
        /// </summary>
        [Description("西药房")]
        WMPharmacy = 1 << 0,
        /// <summary>
        /// 中药房
        /// </summary>
        [Description("中药房")]
        HMPharmacy = 1 << 1,
        /// <summary>
        /// 西药库
        /// </summary>
        [Description("西药库")]
        WMWarehouse = 1 << 2,
        /// <summary>
        /// 中药库
        /// </summary>
        [Description("中药库")]
        HMWarehouse = 1 << 3,
    }

    public enum DeptCategory
    {
        门诊 = 1,
        护理 = 2,
        临床 = 3,
        医技 = 4,
        药剂 = 5,
        行政 = 6,
        财务 = 7,
        处置 = 8,
        其它 = 9,
    }
}
