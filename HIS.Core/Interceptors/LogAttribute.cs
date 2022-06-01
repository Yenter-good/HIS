using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Interceptors
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-18 11:47:13
    /// 描述:
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
    public class LogAttribute : Attribute
    {
        public LogAttribute()
        {

        }
        public LogAttribute(string action)
        {
            this.Action = action;
        }

        /// <summary>
        /// 动作事件
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 日志描述信息
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 日志等级
        /// </summary>
        public LogLevel Level { get; set; } = LogLevel.Info;
    }

    /// <summary>
    /// 日志等级类型枚举
    /// </summary>
    public enum LogLevel
    {
        [Description("警告信息")]
        Warn = 1,
        [Description("调试信息")]
        Debug = 2,
        [Description("一般信息")]
        Info = 3,
        [Description("严重错误")]
        Fatal = 4,
        [Description("错误日志")]
        Error = 5
    }
}
