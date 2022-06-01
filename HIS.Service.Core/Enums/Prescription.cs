using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum PrescriptionStatus
    {
        [Description("未发送")]
        New,
        [Description("发送")]
        Send,
        [Description("收费")]
        Charge,
        [Description("作废")]
        Void,
    }

    public enum SkinTestFlag
    {
        /// <summary>
        /// 不需皮试
        /// </summary>
        [Description("不需皮试")]
        None,
        /// <summary>
        /// 需皮试
        /// </summary>
        [Description("需皮试")]
        Need,
        /// <summary>
        /// 继续使用
        /// </summary>
        [Description("继续使用")]
        Continue
    }

    public enum PrscriptionType
    {
        西药中成药 = 0,
        草药 = 1,
        颗粒剂 = 2,
        治疗和材料 = 3,
        检验 = 4,
        检查 = 5,
    }
}
