using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum SexType
    {
         /// <summary>
         /// 男性
         /// </summary>
        [Description("男")]
        男 = 1 ,
        /// <summary>
        /// 女性
        /// </summary>
        [Description("女")]
        女 = 2 ,
        /// <summary>
        /// 未知性别
        /// </summary>
        [Description("女")]
        未知性别 = 9,
        /// <summary>
        /// 未说明
        /// </summary>
        [Description("未说明")]
        未说明 = 0
    }
}
