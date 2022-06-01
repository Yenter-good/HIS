using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 系统字典风格
    /// </summary>
    public enum SysDicStyle
    {
        /// <summary>
        ///系统字典 
        /// </summary>
        [Description("系统字典")]
        SysDic = 0,
        /// <summary>
        /// 扩展字典
        /// </summary>
        [Description("扩展字典")]
        ExtDic = 1
    }
}
