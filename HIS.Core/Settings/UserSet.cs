using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;

namespace HIS.Core.Settings
{
    /// <summary>
    /// 全局参数设置
    /// </summary>
    public class UserSet
    {
        private System.Collections.Concurrent.ConcurrentDictionary<string, string> cacheKeys = new System.Collections.Concurrent.ConcurrentDictionary<string, string>();

        /// <summary>
        /// 书写规范
        /// </summary>
        public string Test
        {
            get
            {
                return GetOrAdd<string>("HIS_Common1", "HIS_Test", "书写规范", "书写规范", "sdfsdfsdf");
            }
        }

        /// <summary>
        /// 默认西药处方
        /// </summary>
        public string NormalWMPrescriptionTypeCode
        {
            get
            {
                return GetOrAdd<string>("NormalWMPrescriptionTypeCode", "NormalWMPrescriptionTypeCode", "默认西药处方", "默认西药处方", "0");
            }
        }

        /// <summary>
        /// 默认草药处方
        /// </summary>
        public string NormalHMPrescriptionTypeCode
        {
            get
            {
                return GetOrAdd<string>("NormalHMPrescriptionTypeCode", "NormalHMPrescriptionTypeCode", "默认草药处方", "默认草药处方", "3");
            }
        }
        /// <summary>
        /// 默认颗粒剂处方
        /// </summary>
        public string NormalHMGranulesPrescriptionTypeCode
        {
            get
            {
                return GetOrAdd<string>("NormalHMGranulesPrescriptionTypeCode", "NormalHMGranulesPrescriptionTypeCode", "默认颗粒剂处方", "默认草药处方", "4");
            }
        }
        /// <summary>
        /// 默认治疗处方
        /// </summary>
        public string NormalItemPrescriptionTypeCode
        {
            get
            {
                return GetOrAdd<string>("NormalItemPrescriptionTypeCode", "NormalItemPrescriptionTypeCode", "默认治疗处方", "默认治疗处方", "5");
            }
        }

        internal UserSet()
        {

        }
        /// <summary>
        /// 通过参数编码刷新缓存
        /// </summary>
        /// <param name="code"></param>
        public void Refresh(string code)
        {
            if (string.IsNullOrWhiteSpace(code)) return;
            MemoryCache.Default.Remove(code);
        }
        /// <summary>
        /// 刷新缓存
        /// </summary>
        /// <param name="cacheKey">例 nameof(OP_SwitchMedicalInsurance)</param>
        public void RefreshCache(string cacheKey)
        {
            if (cacheKeys.ContainsKey(cacheKey))
            {
                MemoryCache.Default.Remove(cacheKeys[cacheKey]);
            }
        }
        private T GetOrAdd<T>(string cacheKey, string code, string name, string memo, T defaultValue)
        {
            var value = MemoryCache.Default.Get("UserSet" + code);
            if (value == null)
            {

                value = ServiceLocator.GetService<HIS.Service.Core.IUserParameterService>()
                  .GetOrAdd<T>(code, defaultValue, name, new StackTrace().GetFrame(1).GetMethod().Name.Replace("get_", ""), memo);
                if (value == null) return defaultValue;
                MemoryCache.Default.Add(new CacheItem("UserSet" + code, value), new CacheItemPolicy());
                cacheKeys["UserSet" + cacheKey] = code;
            }
            return (T)value;
        }
    }
}
