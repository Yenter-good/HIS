using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IDeptService : IServiceSingleton
    {
        /// <summary>
        /// 获取所有科室
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        List<DeptEntity> GetList(bool includeDisable = false);
        /// <summary>
        /// 获取系统拥有的科室列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<DeptEntity> GetListByApp(long appId);
        /// <summary>
        /// 获取指定系统拥有的默认科室
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<DeptEntity> GetDefaultByApp(long appId);
        /// <summary>
        /// 获取指定用户拥有的所有科室
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<DeptEntity> GetByUser(long userId, long roleId);
        /// <summary>
        /// 停用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult DisableDept(long deptId);
        /// <summary>
        /// 停用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult DisableDepts(List<long> deptIds);
        /// <summary>
        /// 停用指定科室,并重置指定科室的上级科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="idAndParentId"></param>
        /// <returns></returns>
        DataResult DisableDeptWithUpgrade(long deptId, Dictionary<long, long> idAndParentId);
        /// <summary>
        /// 启用指定科室
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult EnableDept(long deptId);
        /// <summary>
        /// 更新科室
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        DataResult UpdateDept(DeptEntity deptEntity);
        /// <summary>
        /// 添加科室
        /// </summary>
        /// <param name="deptEntity"></param>
        /// <returns></returns>
        DataResult AddDept(DeptEntity deptEntity);
        /// <summary>
        /// 科室编号是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ExistCode(string code);
        /// <summary>
        /// 获取指定明细分类的科室列表
        /// </summary>
        /// <param name="categoryDetail"></param>
        /// <returns></returns>
        List<DeptEntity> GetList(DeptCategoryDetail categoryDetail);
        /// <summary>
        /// 根据指定类型查询
        /// </summary>
        /// <param name="categoryDetailList"></param>
        /// <returns></returns>
        List<DeptEntity> GetListByCategoryDetail(List<DeptCategoryDetail> categoryDetailList);
        /// <summary>
        /// 获取指定科室对应的药房 
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DeptEntity> GetPharmacy(long deptId);
        /// <summary>
        /// 获取指定科室对应的药房 
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DeptPharmacyEntity> GetPharmacyMapper(long deptId);
        /// <summary>
        /// 增加科室对应药房关系
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="pharmacyId"></param>
        /// <returns></returns>
        DataResult<DeptPharmacyEntity> AddMapper(long deptId, long pharmacyId);
        /// <summary>
        /// 删除科室对应药房关系
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<DeptPharmacyEntity> DeleteMapper(long entityId);

        /// <summary>
        /// 删除科室对应药房关系
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<DeptPharmacyEntity> DeleteMapper(long deptId, long pharmacId);
        /// <summary>
        /// 根据指定分类查询
        /// </summary>
        /// <param name="deptCategory"></param>
        /// <returns></returns>
        List<DeptEntity> GetListByCategory(DeptCategory deptCategory, DeptCategoryDetail categoryDetail = DeptCategoryDetail.None);
        /// <summary>
        /// 根据指定分类查询
        /// </summary>
        /// <param name="deptCategories"></param>
        /// <returns></returns>
        List<DeptEntity> GetListByCategory(List<DeptCategory> deptCategories, DeptCategoryDetail categoryDetail = DeptCategoryDetail.None);
    }
}
