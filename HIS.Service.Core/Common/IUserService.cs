using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:49:34
/// 功能:
/// </summary>
namespace HIS.Service.Core
{
    public interface IUserService : IServiceSingleton
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserEntity Get(long id);
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserEntity Get(long id, long roleId);
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        List<UserEntity> GetAll();
        /// <summary>
        /// 获取所有用户，带权限信息
        /// </summary>
        /// <returns></returns>
        List<UserEntity> GetAllWithRole();
        /// <summary>
        /// 获取系统模块列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<AppEntity> GetAppList(UserEntity user, long roleId);
        /// <summary>
        /// 验证账号密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        UserEntity ValidationAccount(string account, string password);
        /// <summary>
        /// 获取用户当前系统下授权科室列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<DeptEntity> GetDeptListByApp(long appId);
        /// <summary>
        /// 获取用户授权的菜单列表
        /// </summary>
        /// <param name="user"></param>
        /// <param name="appId"></param>
        /// <param name="deptIds"></param>
        /// <returns></returns>
        List<MenuEntity> GetMenuList(UserEntity user, long appId);
        /// <summary>
        /// 获取指定角色下所有用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<UserEntity> GetByRole(long roleId);
        /// <summary>
        /// 获取指定科室下的用户
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<UserEntity> GetByDept(long deptId);
        /// <summary>
        /// 停用指定用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        DataResult DisableUser(long userId);
        /// <summary>
        /// 启用指定用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        DataResult EnableUser(long userId);
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="additionEntities"></param>
        /// <returns></returns>
        DataResult UpdateUser(long userId, UserEntity userEntity, Dictionary<RoleAdditionalEntity, List<DeptEntity>> roleAdditional);
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="additionEntities"></param>
        /// <returns></returns>
        DataResult InsertUser(UserEntity userEntity);
        /// <summary>
        /// 用户工号是否已存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ExistCode(string code);
   
    }
}
