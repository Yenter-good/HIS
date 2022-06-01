using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 节点类型
    /// </summary>
    public enum NodeType
    {
        /// <summary>
        /// 文件夹
        /// </summary>
        Folder = 0,
        /// <summary>
        /// 内容
        /// </summary>
        Content = 1
    }
    /// <summary>
    /// 节点等级
    /// </summary>
    public enum Level
    {
        /// <summary>
        /// 科室
        /// </summary>
        [Description("科室")]
        Dept = 0,
        /// <summary>
        /// 用户
        /// </summary>
        [Description("个人")]
        User = 1
    }
}
