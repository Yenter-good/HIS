using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-04 09:23:13
    /// 描述:
    /// </summary>
    public interface IIntervalService : IServiceSingleton
    {
        /// <summary>
        /// 获取所有间隔字典
        /// </summary>
        /// <param name="type">0西药 1草药</param>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        List<IntervalEntity> GetAll(int type, bool includeDisable = false);
        /// <summary>
        /// 获取指定id的间隔
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        IntervalEntity Get(long intervalId);
        /// <summary>
        /// 获取指定id的间隔
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        IntervalEntity Get(string intervalCode);
    }
}
