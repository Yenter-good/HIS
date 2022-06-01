using HIS.Core.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Interceptors
{
    /// <summary>
    /// 设置判断缓存拦截方法的特性类
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
    public class CacheMethodAttribute:Attribute
    {
        /// <summary>
        /// 缓存类型
        /// </summary>
        public CacheProviderType CacheProviderType { get; set; } = CacheProviderType.Default;
        /// <summary>
        /// 有效时间 
        /// 单位秒
        /// 当前启用二级缓存后此设置无效
        /// </summary>
        public int Time { get; set; } = 60;
        /// <summary>
        /// 缓存的方法
        /// </summary>
        public CachingMethod Method { get; set; }
        /// <summary>
        /// 获取或设置一个值，该值表示当缓存方式为Put时，是否强制将值写入缓存中。
        /// </summary>
        public bool Force { get; set; }
        /// <summary>
        /// 缓存的键
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 获取或设置与当前缓存方式相关的方法名称。注：此参数仅在缓存方式为Remove时起作用。
        /// </summary>
        public string[] CorrespondingKeys { get; set; }
        /// <summary>
        /// 获取或设置与当前缓存方式相关的方法名称。注：此参数仅在缓存方式为Remove时起作用。
        /// 通过前缀方式移除其相关的缓存
        /// </summary>
        public string[] PrefixKeys { get; set; }

        #region 构造函数
        /// <summary>
        /// 初始化一个新的<c>InterceptMethodAttribute</c>类型。
        /// </summary>
        /// <param name="method">缓存方式。</param>
        public CacheMethodAttribute(CachingMethod method)
        {
            this.Method = method;
        }
        /// <summary>
        /// 初始化一个新的<c>InterceptMethodAttribute</c>类型。
        /// </summary>
        /// <param name="method">缓存方式。</param>
        /// <param name="correspondingMethodNames">与当前缓存方式相关的方法名称。注：此参数仅在缓存方式为Remove时起作用。</param>
        public CacheMethodAttribute(CachingMethod method, params string[] correspondingMethodNames)
            : this(method)
        {
            this.CorrespondingKeys = correspondingMethodNames;
        }
        #endregion
    }
}
