using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum UsageType
    {
        [Description("西药")]
        WesternMedicine,
        [Description("中药")]
        ChinestMedicine
    }
}
