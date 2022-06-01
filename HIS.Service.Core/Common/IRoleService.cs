using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:50:05
/// 功能:
/// </summary>
namespace HIS.Service.Core
{
    public interface IRoleService : IServiceSingleton
    {
        /// <summary>
        /// 获取指定用户拥有的所有角色
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<RoleEntity> GetByUser(long userId);

        /// <summary>
        /// 获取指定角色下的权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<LongItem> GetAuthority(long roleId);
        /// <summary>
        /// 获取指定角色下的权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<LongItem> GetAuthorityWithoutCache(long roleId);
        /// <summary>
        /// 获得所有角色列表
        /// </summary>
        /// <returns></returns>
        List<RoleEntity> GetAll();
        /// <summary>
        /// 给指定角色插入菜单
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuIds"></param>
        /// <returns></returns>
        DataResult InsertMenus(long roleId, List<long> menuIds);
        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="leval"></param>
        /// <returns></returns>
        DataResult<RoleEntity> Insert(string code, string name, string description, int leval);
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult Delete(long id);

        /// <summary>
        /// 给指定角色插入权限集
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="codes"></param>
        /// <returns></returns>
        DataResult InsertPermission(long roleId, List<string> codes);
        /// <summary>
        /// 删除指定角色下的用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        DataResult DeleteUser(long roleId, long userId);
        /// <summary>
        /// 在指定角色下增加用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        DataResult InsertUser(long roleId, long userId);
        /// <summary>
        /// 获取指定用户在指定角色下的附加信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        RoleAdditionalEntity GetAddition(long roleId, long userId);
        /// <summary>
        /// 获得指定用户的所有角色附加信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<RoleAdditionalEntity> GetAllAddition(long userId);
    }
}
