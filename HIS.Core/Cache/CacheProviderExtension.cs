using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Cache
{
    public static class CacheProviderExtension
    {
        public static T GetFromCacheFirst<T>(this ICachingProvider cacheProvider, string key, Func<T> getFromPersistence, int? storeTime = null) where T : class
        {
            object returnValue;
            try
            {
                var cacheValue = cacheProvider.Get(key);
                if (cacheValue==null)
                {
                    returnValue = getFromPersistence();
                    if (returnValue != null)
                    {
                        if (storeTime.HasValue)
                        {
                            cacheProvider.Remove(key);
                            cacheProvider.Set(new CacheEntry(key,returnValue, storeTime.Value) );
                        }
                        else
                        {
                            cacheProvider.Remove(key);
                            cacheProvider.Set(new CacheEntry(key, returnValue));
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
