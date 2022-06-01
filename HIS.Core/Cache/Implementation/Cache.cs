using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache.Implementation
{
    class Cache
    {
        private static ConcurrentDictionary<string, ICachingProvider> _cacheKeys = new ConcurrentDictionary<string, ICachingProvider>();
        private static ConcurrentDictionary<CacheProviderType, ICachingProvider> _cacheProviders = new ConcurrentDictionary<CacheProviderType, ICachingProvider>();


        public static List<string> CacheKeys
        {
            get
            {
                return _cacheKeys.Keys.ToList();
            }
        }
        /// <summary>
        /// 获取指定类型的缓存提供器
        /// </summary>
        /// <param name="providerType"></param>
        /// <returns></returns>
        private static ICachingProvider GetCachingProvider(CacheProviderType providerType)
        {
            ICachingProvider cachingProvider = null;
            if (_cacheProviders.TryGetValue(providerType,out cachingProvider))
            {
                return cachingProvider;
            }
            switch (providerType)
            {
                case CacheProviderType.Default:
                    cachingProvider = new Implementation.CachingProvider();
                    break;
                case CacheProviderType.L2Cache:
                    cachingProvider = new Implementation.L2CachingProvider();
                    break;
                default:
                    break;
            }
            _cacheProviders[providerType] = cachingProvider;
            return cachingProvider;
        }
        /// <summary>
        /// 指定缓存键是否过期
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <param name="startWidth"></param>
        /// <returns></returns>
        public static bool IsExpired(string cacheKey)
        {
           return Get(cacheKey) == null;
        }
        /// <summary>
        /// 获取指定键值缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Get(string key)
        {
            if (_cacheKeys.ContainsKey(key))
            {
                return _cacheKeys[key].Get(key);
            }
            return null;
        }
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="cacheEntry"></param>
        /// <param name="providerType"></param>
        public static void Set(CacheEntry cacheEntry, CacheProviderType providerType)
        {
            if (cacheEntry == null) return;
            var cachingProvider = GetCachingProvider(providerType);
            if (cachingProvider == null) return;
            _cacheKeys[cacheEntry.CacheKey] = cachingProvider;
            cachingProvider.Set(cacheEntry);
        }
        /// <summary>
        /// 移除指定缓存
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            ICachingProvider cachingProvider;
            if (_cacheKeys.TryRemove(key, out cachingProvider))
                cachingProvider.Remove(key);
        }
        /// <summary>
        /// 通过指定键包含当前缀的缓存
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveByPrefixKey(string key)
        {
            foreach (var cacheKey in _cacheKeys.ToArray())
            {
                if (cacheKey.Key.StartsWith(key))
                {
                    Remove(cacheKey.Key);
                }
            }
        }
        /// <summary>
        /// 释放所有过期的缓存
        /// </summary>
        public static void FlushAllExpiration()
        {
            foreach (var item in _cacheKeys.Values.Distinct())
            {
                item.FlushAllExpiration();
            }
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="providerType"></param>
        /// <param name="key"></param>
        /// <param name="getFromPersistence"></param>
        /// <param name="storeTime"></param>
        /// <returns></returns>
        public static T GetFromCacheFirst<T>(CacheProviderType providerType, string key, Func<T> getFromPersistence, int? storeTime = null) where T : class
        {
            object returnValue;
            try
            {
                var cacheValue = Get(key);
                if (cacheValue == null)
                {
                    returnValue = getFromPersistence();
                    if (returnValue != null)
                    {
                        if (storeTime.HasValue)
                        {
                            Remove(key);
                            Set(new CacheEntry(key, returnValue, storeTime.Value), providerType);
                        }
                        else
                        {
                            Remove(key);
                            Set(new CacheEntry(key, returnValue), providerType);
                        }
                    }
                }
                else
                {
                    returnValue = cacheValue;
                }
                return returnValue as T;
            }
            catch
            {
                returnValue = getFromPersistence();
                return returnValue as T;
            }
        }
    }
}
