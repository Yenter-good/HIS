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
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 15:05:09
    /// 描述:
    /// </summary>
    public interface IDrugInventoryService : IServiceSingleton
    {
        /// <summary>
        /// 获取指定药库所有药品库存
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> WarehouseGetAllInventory(long deptId);
        /// <summary>
        /// 获取指定药库指定检索码的药品库存
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="searchCode"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> WarehouseGetInventory(long deptId, string searchCode, int number = 0);
        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        List<DrugInventoryEntity> PharmacyGetInventory(long deptId, bool includeDisable = false);
        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        List<DrugInventoryEntity> PharmacyGetInventory(long deptId, bool includeDisable = false, params DrugType[] drugType);
        /// <summary>
        /// 获取指定科室的药品库存
        /// </summary>
        /// <param name="deptId">科室ID</param>
        /// <returns></returns>
        List<DrugInventoryEntity> PharmacyGetInventory(long deptId, string searchCode, int number = 0);
        /// <summary>
        /// 根据ID获取药品
        /// </summary>
        /// <param name="inventoryId">药房库存药品Id</param>
        /// <returns></returns>
        DrugInventoryEntity PharmacyGetInventoryById(long inventoryId, bool includeDisable = false);

        /// <summary>
        /// 获取全院级别的 药品信息
        /// </summary>
        /// <returns></returns>
        List<DrugInventoryEntity> WholehospitalDrugInfoGetAll();

    }
}
