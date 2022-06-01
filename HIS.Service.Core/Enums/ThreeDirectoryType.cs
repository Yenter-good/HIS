using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum ThreeDirectoryType
    {
        [System.ComponentModel.Description("诊疗")]
        诊疗 = 1,
        [System.ComponentModel.Description("材料")]
        材料 = 2,
        [System.ComponentModel.Description("药品")]
        药品 = 3,
    }
}
