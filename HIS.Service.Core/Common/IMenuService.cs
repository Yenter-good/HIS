using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMenuService : IServiceSingleton
    {
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        List<MenuEntity> GetList(long appId, bool includeDisable = false);
        /// <summary>
        /// 获取菜单分类
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<MenuEntity> GetCategoryList(long appId);
        /// <summary>
        /// 插入菜单
        /// </summary>
        /// <param name="appId">系统ID</param>
        /// <param name="menu">菜单信息</param>
        /// <returns></returns>
        MenuEntity Insert(long appId, MenuEntity menu);
        /// <summary>
        /// 更新菜单信息
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="menu"></param>
        /// <returns></returns>
        DataResult Update(long menuId, MenuEntity menu);
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        DataResult Delete(long menuId);
        /// <summary>
        /// 根据角色id获得菜单实体
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<MenuEntity> GetByRole(long roleId);
    }
}
