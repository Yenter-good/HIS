using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 用户性质
    /// </summary>
    public enum UserNature
    {
        /// <summary>
        /// 员工
        /// </summary>
        [Description("员工")]
        Staff = 0
            ,
        /// <summary>
        /// 试用员工
        /// </summary>
        [Description("试用员工")]
        Probationary = 1
            ,
        /// <summary>
        /// 实习员工
        /// </summary>
        [Description("实习员工")]
        Internship = 2
            ,
        /// <summary>
        /// 进修
        /// </summary>
        [Description("进修")]
        Training = 3
    }
}
