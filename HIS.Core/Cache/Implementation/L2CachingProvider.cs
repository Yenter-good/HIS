using CacheManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache.Implementation
{
    class L2CachingProvider : ICachingProvider
    {
        private ICacheManager<object> _cacheManager;
        public L2CachingProvider()
        {
            _cacheManager = CacheFactory.Build(settings =>
            {
                settings
                .WithSystemRuntimeCacheHandle("inProcessCache")//内存缓存Handle
                .WithExpiration(ExpirationMode.Sliding, TimeSpan.FromSeconds(60))
                .And
                .WithRedisConfiguration("redis", config =>//Redis缓存配置
                                {
                    config.WithAllowAdmin()
                        .WithDatabase(0)
                        .WithEndpoint("192.168.10.113", 6379);

                })
                .WithMaxRetries(1000)//尝试次数
                .WithRetryTimeout(100)//尝试超时时间
                .WithRedisBackplane("redis")//redis使用Back Plate
                .WithRedisCacheHandle("redis", true)//redis缓存handle
                .WithExpiration(ExpirationMode.Sliding, TimeSpan.FromHours(24));
            });
        }

        public void FlushAllExpiration()
        {
            
        }

        public object Get(string key)
        {
           return _cacheManager.Get(key);
        }

        public void Remove(string key)
        {
            _cacheManager.Remove(key);
        }
       
        public void Set(CacheEntry cacheEntry)
        {
            _cacheManager.Put(cacheEntry.CacheKey, cacheEntry.CacheValue);
        }
    }
}
