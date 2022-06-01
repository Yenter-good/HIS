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
    public interface IProcurementPlanService : IServiceSingleton
    {
        //获取采购计划申请单列表
        List<ProcurementPlanEntity> GetAll();

        /// <summary>
        /// 新增采购计划
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<ProcurementPlanEntity> AddPlan(ProcurementPlanEntity entity);

        /// <summary>
        /// 完成采购计划
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<ProcurementPlanEntity> OverPlan(long entityId);

        /// <summary>
        /// 删除采购计划及明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<ProcurementPlanEntity> DeletePlan(long entityId);

        /// <summary>
        /// 根据计划ID获取采购计划明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<ProcurementPlanDetailEntity> GetByPlanId(long entityId);

        /// <summary>
        /// 根据筛选条件 查询对应采购明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        List<ProcurementPlanDetailEntity> GetBySearchStr(long entityId, string searchStr);

        /// <summary>
        /// 更改采购明细 数量
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        DataResult<ProcurementPlanDetailEntity> UpdateDetailQuantity(long entityId, int quantity);
        /// <summary>
        /// 按规则填充采购明细的采购量
        /// </summary>
        /// <param name="entityId">采购计划ID</param>
        /// <param name="type">规则类型</param>
        /// <returns></returns>
        DataResult FillQuantity(long entityId, int type);
    }
}
