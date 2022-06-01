
using Castle.DynamicProxy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HIS.Core.Interceptors
{
    public class CacheInterceptor : IInterceptor
    {
        public CacheInterceptor()
        {
        }
        public void Intercept(IInvocation invocation)
        {
            var cacheMethod = GetCachingAttribute(invocation.MethodInvocationTarget ?? invocation.Method);
            if (cacheMethod == null)
            {
                //无缓存标识 则照常操作
                invocation.Proceed();
                return;
            }
            this.ProceedCaching(invocation, cacheMethod);
        }
        private CacheMethodAttribute GetCachingAttribute(MethodInfo method)
        {
            return method.GetCustomAttributes<CacheMethodAttribute>(true).FirstOrDefault();
        }
        /// <summary>
        /// 缓存处理操作
        /// </summary>
        /// <param name="invocation"></param>
        /// <param name="attribute"></param>
        private void ProceedCaching(IInvocation invocation, CacheMethodAttribute attribute)
        {
            var keys = GetKeys(invocation);
            string cacheKey = attribute.Key.AsString("");
            if (!string.IsNullOrWhiteSpace(attribute.Key) && keys != null)
            {
                cacheKey = string.Format(attribute.Key, keys);
                if (string.IsNullOrWhiteSpace(cacheKey))
                {
                    invocation.Proceed();
                    return;
                }
            }
            switch (attribute.Method)
            {
                case CachingMethod.Get:
                    var retrunValue = HIS.Core.Cache.Implementation.Cache.GetFromCacheFirst(attribute.CacheProviderType, cacheKey, () =>
                      {
                          invocation.Proceed();
                          return invocation.ReturnValue;
                      }, attribute.Time);
                    invocation.ReturnValue = retrunValue;
                    break;
                case CachingMethod.Put:
                case CachingMethod.Remove:
                default:
                    invocation.Proceed();
                    if (attribute.CorrespondingKeys != null)
                    {
                        var keyList = attribute.CorrespondingKeys.Select(correspondingKey => string.Format(correspondingKey, keys)).ToList();
                        keyList.ForEach(HIS.Core.Cache.Implementation.Cache.Remove);
                    }
                    if (attribute.PrefixKeys != null && attribute.PrefixKeys.Length > 0)
                    {
                        var list = attribute.PrefixKeys.Select(d => d.Replace("{0}", "")
                                                                    .Replace("{1}", "")
                                                                    .Replace("{2}", "")
                                                                    .Replace("{3}", "")
                        ).ToList();
                        list.ForEach(HIS.Core.Cache.Implementation.Cache.RemoveByPrefixKey);
                    }
                    break;
            }

        }
        /// <summary>
        /// 获取标识key
        /// </summary>
        /// <param name="invocation"></param>
        /// <returns></returns>
        private string[] GetKeys(IInvocation invocation)
        {
            var args = invocation.Arguments;
            if (args == null || args.Length == 0) return null;

            string[] keys = new string[0];
            foreach (var arg in args)
            {
                keys = keys.Concat(this.GetArgumentValue(arg)).ToArray();
            }
            return keys;
        }
        private string[] GetArgumentValue(object arg)
        {
            if (arg == null)
                return new string[] { "" };
            if (arg is int || arg is long || arg is string) return new string[] { arg.ToString() };
            if (arg is DateTime)
                return new string[] { ((DateTime)arg).ToString("yyyyMMddHHmmss") };
            if (arg is Array)
                return new string[] { string.Join(",", ((Array)arg).Cast<object>().ToArray()) };
            if (arg is Dos.ORM.Entity)
            {
                var entity = arg as Dos.ORM.Entity;
                var primaryKeys = entity.GetPrimaryKeyFields();
                if (primaryKeys != null && primaryKeys.Length > 0)
                {
                    var fields = entity.GetFields();
                    var values = entity.GetValues();
                    string[] results = new string[primaryKeys.Length];
                    int index = 0;
                    foreach (var pk in primaryKeys)
                    {
                        results[index] = values[Array.IndexOf(fields, pk)].AsNotNullString();
                        index++;
                    }
                    return results;
                }
            }
            if (!(arg is IEnumerable))
            {
                var runtimeProperties = arg.GetType().GetRuntimeProperties();
                var properties = (from q in runtimeProperties
                                  let k = q.GetCustomAttribute<KeyAttribute>()
                                  where k != null
                                  orderby (k as KeyAttribute).SortIndex
                                  select q).ToList();

                return properties.Count() > 0 ? properties.Select(p => p.GetValue(arg).AsNotNullString().ToString()).ToArray() : new string[] { arg.AsNotNullString() };
            }
            return new string[] { arg.AsNotNullString() };
        }
    }
}
