using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache
{
    /// <summary>
    /// Cache entry.
    /// </summary>
    public class CacheEntry
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheKey">Cache key.</param>
        /// <param name="cacheValue">缓存值</param>
        /// <param name="expiration">设置多少秒后过期</param>
        /// <param name="isRemoveExpiratedAfterSetNewCachingItem">If set to <c>true</c> is remove expirated after set new caching item.</param>
        public CacheEntry(string cacheKey,
                          object cacheValue,
                          int expiration = 60,
                          bool isRemoveExpiratedAfterSetNewCachingItem = true)
        {
            if (string.IsNullOrWhiteSpace(cacheKey))
            {
                throw new ArgumentNullException(nameof(cacheKey));
            }

            if (cacheValue == null)
            {
                throw new ArgumentNullException(nameof(cacheValue));
            }

            if (expiration <= 0)
            {
                throw new ArgumentOutOfRangeException(
                        nameof(Expiration),
                        expiration,
                        "The relative expiration value must be positive.");
            }

            this.CacheKey = cacheKey;
            this.CacheValue = cacheValue;
            this.Expiration = expiration;
            this.IsRemoveExpiratedAfterSetNewCachingItem = isRemoveExpiratedAfterSetNewCachingItem;
        }

        /// <summary>
        /// 缓存键
        /// </summary>
        public string CacheKey { get; private set; }

        /// <summary>
        /// 缓存值
        /// </summary>
        public object CacheValue { get; private set; }

        /// <summary>
        ///设置多少秒后过期.
        /// </summary>
        public int Expiration { get; private set; }

        /// <summary>
        /// 每次设置值的时候移除过期的数据
        /// </summary>
        public bool IsRemoveExpiratedAfterSetNewCachingItem { get; private set; }

        /// <summary>
        ///序列化缓存值
        /// </summary>
        public string SerializeCacheValue
        {
            get
            {
                if (this.CacheValue == null)
                {
                    throw new ArgumentNullException(nameof(this.CacheValue));
                }
                else
                {
                    return JsonConvert.SerializeObject(this.CacheValue);
                }
            }
        }

    }
}
