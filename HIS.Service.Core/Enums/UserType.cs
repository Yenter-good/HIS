using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 用户类型
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// 医生
        /// </summary>
        [Description("医生")]
        Doctor = 1
            ,
        /// <summary>
        /// 护士
        /// </summary>
        [Description("护士")]
        Nurse = 2
            ,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0
                ,
        /// <summary>
        /// 收费员
        /// </summary>
        [Description("收费员")]
        Cashier = 4,
        /// <summary>
        /// 管理员
        /// </summary>
        [Description("管理员")]
        Admin = 5
    }
}
