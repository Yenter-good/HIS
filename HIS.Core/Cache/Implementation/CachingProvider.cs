using CacheManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache.Implementation
{
    class CachingProvider : ICachingProvider
    {

        private ICacheManager<object> _cacheManager;
        public CachingProvider()
        {
            _cacheManager = CacheFactory.Build(settings => {
                settings.WithSystemRuntimeCacheHandle();
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
            _cacheManager.Put(new CacheItem<object>(cacheEntry.CacheKey, cacheEntry.CacheValue, ExpirationMode.Absolute, TimeSpan.FromSeconds(cacheEntry.Expiration)));
        }

    }
}
