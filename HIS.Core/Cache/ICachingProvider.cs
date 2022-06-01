using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache
{
    public interface ICachingProvider
    {
        /// <summary>
        /// 获取指定键的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object Get(string key);
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="cacheEntry"></param>
        void Set(CacheEntry cacheEntry);
        /// <summary>
        /// 移除指定键的缓存
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);
        /// <summary>
        /// 释放所有过期的缓存
        /// </summary>
        void FlushAllExpiration();
    }
}
