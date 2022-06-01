using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IUsageService : IServiceSingleton
    {
        /// <summary>
        /// 获取所有用法字典
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        List<UsageEntity> GetAll(bool includeDisable = false);
        /// <summary>
        /// 获取所有用法字典,0西药,1中药
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        List<UsageEntity> GetAll(int category);
        /// <summary>
        /// 获取指定id的用法
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        UsageEntity Get(long usageId);
        /// <summary>
        /// 获取指定id的用法
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        UsageEntity Get(string usageCode);
        /// <summary>
        /// 更新用法
        /// </summary>
        /// <param name="usageEntity"></param>
        /// <returns></returns>
        DataResult Update(UsageEntity usageEntity);
        /// <summary>
        /// 插入用法
        /// </summary>
        /// <param name="usageEntity"></param>
        /// <returns></returns>
        DataResult Insert(UsageEntity usageEntity);
        /// <summary>
        /// 是否有重复code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ExistCode(string code);
        /// <summary>
        /// 启用指定用法
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        DataResult EnableUsage(long Id);
        /// <summary>
        /// 停用指定用法
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        DataResult DisableUsage(long Id);
        /// <summary>
        /// 获取指定剂型下的默认用法
        /// </summary>
        /// <param name="drugformId"></param>
        /// <returns></returns>
        UsageEntity GetDrugformDefault(long drugformId);
        /// <summary>
        /// 获取所有剂型和用法的对应关系
        /// </summary>
        /// <returns></returns>
        Dictionary<long, List<UsageEntity>> GetAllDrugformUsageMapper();
        /// <summary>
        /// 获取指定剂型下的所有用法ID
        /// </summary>
        /// <param name="drugformId"></param>
        /// <returns></returns>
        List<UsageEntity> GetDrugformUsageMapper(long drugformId);
        /// <summary>
        /// 将指定用法添加到指定剂型下
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        DataResult AddToDrugform(long drugformId, long usageId);
        /// <summary>
        /// 将一组用法添加到指定剂型下
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageIds"></param>
        /// <returns></returns>
        DataResult AddToDrugform(long drugformId, List<long> usageIds);
        /// <summary>
        /// 将指定用法从指定剂型下删除
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        DataResult DeleteFromDrugform(long drugformId, long usageId);
        /// <summary>
        /// 将一组用法从指定剂型下删除
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageIds"></param>
        /// <returns></returns>
        DataResult DeleteFromDrugform(long drugformId, List<long> usageIds);
        /// <summary>
        /// 将指定剂型下的指定用法设为默认,并将同剂型下的其他用法设为不默认
        /// </summary>
        /// <param name="drugformId"></param>
        /// <param name="usageId"></param>
        /// <returns></returns>
        DataResult SetDefault(long drugformId, long usageId);
    }
}
