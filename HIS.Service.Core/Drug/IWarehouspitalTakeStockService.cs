using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Entities.Drug;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core
{
    /// <summary>
    /// 药库盘点服务
    /// </summary>
    public interface IWarehouspitalTakeStockService : IServiceSingleton
    {
        //获取盘点单列表
        List<TakeStockEntity> GetByDate(long DeptId,DateTime start, DateTime end);

        /// <summary>
        /// 新增盘点
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<TakeStockEntity> AddTakeStock(long DeptId, TakeStockEntity entity);

        /// <summary>
        /// 完成盘点
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<TakeStockEntity> OverTakeStock(long entityId);

        /// <summary>
        /// 删除盘点及明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<TakeStockEntity> DeleteTakeStock(long entityId);

        /// <summary>
        /// 根据计划ID获取盘点明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<TakeStockDetailEntity> GetByTakeStockId(long entityId);

        /// <summary>
        /// 根据筛选条件 查询对应盘点明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        List<TakeStockDetailEntity> GetBySearchStr(long entityId, string searchStr);

        /// <summary>
        /// 更改盘点明细 数量
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        DataResult<TakeStockDetailEntity> UpdateDetailQuantity(long entityId, int quantity);
    
    }
}
