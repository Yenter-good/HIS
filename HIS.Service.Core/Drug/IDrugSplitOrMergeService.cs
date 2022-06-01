using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:wfg
    /// 创建时间:2021-01-23 11:59:09
    /// 描述:
    /// </summary>
    public interface IDrugSplitOrMergeService : IServiceSingleton
    {
        /// <summary>
        /// 药品拆分与合并
        /// </summary>
        /// <param name="inventoryId">药品实体</param>
        /// <param name="pharmacy">药房标识</param>
        /// <param name="Operation">操作类型</param>
        /// <param name="operationPackageNumber">操作的包装数</param>
        /// <returns></returns>
        DataResult DrugSplitOrMerge(long inventoryId, int pharmacy, int Operation, int operationPackageNumber = 0);
    }
}
