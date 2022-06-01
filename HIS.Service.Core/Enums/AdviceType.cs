using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum AdviceType
    {
        [System.ComponentModel.Description("检查")]
        检查 = 1,
        [System.ComponentModel.Description("检验")]
        检验 = 2,
        [System.ComponentModel.Description("处置")]
        处置 = 3,
        [System.ComponentModel.Description("护理")]
        护理 = 4,
        [System.ComponentModel.Description("膳食")]
        膳食 = 5,
        [System.ComponentModel.Description("嘱托")]
        嘱托 = 6,
        [System.ComponentModel.Description("手术")]
        手术 = 7,
        [System.ComponentModel.Description("其他")]
        其他 = 8
    }
    public enum AdviceCategoryType
    {
        Test = 0,
        Inspect = 1
    }
}
