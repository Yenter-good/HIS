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
    public class GlobalSet
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
        /// 进货价加成系数
        /// </summary>
        public float PurchasePriceBonusCoefficient
        {
            get
            {
                return GetOrAdd<float>("PurchasePriceBonusCoefficient", "PurchasePriceBonusCoefficient", "进货价加成系数", "", 1);
            }
        }
        /// <summary>
        /// 日志输出模式
        /// </summary>
        public string LogMode
        {
            get
            {
                return GetOrAdd<string>("LogMode", "LogMode", "日志输出模式", "", "SqlServer");
            }
        }
        /// <summary>
        /// 门诊日志必填字段
        /// </summary>
        public List<StringItem> JournalRequiredField
        {
            get
            {
                return GetOrAdd<List<StringItem>>("JournalRequiredField", "JournalRequiredField", "门诊日志必填字段", "", new List<StringItem>());
            }
        }
        /// <summary>
        /// 门诊患者有效天数
        /// </summary>
        public int OPPatientEffectiveDay
        {
            get
            {
                return GetOrAdd<int>("OPPatientEffectiveDay", "OPPatientEffectiveDay", "门诊患者有效天数", "", 3);
            }
        }
        /// <summary>
        /// 门诊草药颗粒剂模式 0合并开具 1分开开具
        /// </summary>
        public int OPHMGranulesMode
        {
            get
            {
                return GetOrAdd<int>("OPHMGranulesMode", "OPHMGranulesMode", "门诊草药颗粒剂模式 0合并开具 1分开开具", "", 1);
            }
        }
        /// <summary>
        /// 病史摘要节点
        /// </summary>
        public List<string> OPConditionSummaryNode
        {
            get
            {
                List<string> result = new List<string>()
                {
                    "ChiefComplaints",
                    "PresentIllness",
                    "Past"
                };
                return GetOrAdd<List<string>>("OPConditionSummaryNode", "OPConditionSummaryNode", "病史摘要节点", "", result);
            }
        }
        internal GlobalSet()
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
            var value = MemoryCache.Default.Get(code);
            if (value == null)
            {

                value = ServiceLocator.GetService<HIS.Service.Core.ISystemParameterService>()
                  .GetOrAdd<T>(code, defaultValue, name, new StackTrace().GetFrame(1).GetMethod().Name.Replace("get_", ""), memo);
                if (value == null) return defaultValue;
                MemoryCache.Default.Add(new CacheItem(code, value), new CacheItemPolicy());
                cacheKeys[cacheKey] = code;
            }
            return (T)value;
        }
    }
}
