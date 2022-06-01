using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 类型路径
    /// </summary>
    public class TypeUri
    {
        /// <summary>
        /// 程序集
        /// </summary>
        public string Assembly { get; set; }
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName { get; set; }
        public TypeUri() { }
        public TypeUri(Type type)
        {
            this.Assembly = type.Assembly.GetName().Name;
            this.ClassName = type.FullName;
        }
        public TypeUri(string assembly, string className)
        {
            this.Assembly = assembly;
            this.ClassName = className;
        }
        public TypeUri(string uri)
        {
            if (uri.IsNullOrWhiteSpace())
                return;
            if (uri.StartsWith("win:"))
            {
                var values = uri.Substring(4, uri.Length - 4).Split('|');
                if (values.Length == 2)
                {
                    this.Assembly = values[0];
                    this.ClassName = values[1];
                }
            }
        }
        /// <summary>
        /// 是否有效
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            if (this.Assembly.IsNullOrWhiteSpace()) return false;
            if (this.ClassName.IsNullOrWhiteSpace()) return false;
            return true;
        }
        /// <summary>
        /// 获取实例的类型
        /// </summary>
        /// <returns></returns>
        public Type GetIntanceType()
        {
            return System.Reflection.Assembly.Load(this.Assembly).GetType(this.ClassName);
        }
        public string GetUri()
        {
            return $"win:{this.Assembly}|{this.ClassName}";
        }
    }
}
