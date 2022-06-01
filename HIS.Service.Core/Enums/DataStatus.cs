using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 数据状态
    /// </summary>
    public enum DataStatus
    {
        [System.ComponentModel.Description("停用")]
        Disable = 0,
        [System.ComponentModel.Description("启用")]
        Enable = 1,
        [System.ComponentModel.Description("作废")]
        Delete = 2
    }
}
