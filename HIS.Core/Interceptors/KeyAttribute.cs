using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Interceptors
{
    /// <summary>
    /// CacheKeyAttribute 自定义特性类
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property,
        AllowMultiple = false)]
    public abstract class KeyAttribute : Attribute
    {
        protected KeyAttribute(int sortIndex)
        {
            SortIndex = sortIndex;
        }
        public int SortIndex { get; set; }
    }
}
