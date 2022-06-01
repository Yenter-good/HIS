using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:49:49
/// 功能:
/// </summary>
namespace HIS.Service.Core
{
    public interface IAppService : IServiceSingleton
    {
        /// <summary>
        /// 获取系统模块列表
        /// </summary>
        /// <param name="includeDisable">是否包含禁用的</param>
        /// <returns></returns>
        List<AppEntity> GetList(bool includeDisable = false);
        /// <summary>
        /// 添加系统
        /// </summary>
        /// <param name="appEntity"></param>
        /// <returns></returns>
        AppEntity Insert(AppEntity appEntity);
        /// <summary>
        /// 更新系统模块
        /// </summary>
        /// <param name="id"></param>
        /// <param name="appEntity"></param>
        /// <returns></returns>
        DataResult Update(long id, AppEntity appEntity);
        /// <summary>
        /// 删除系统模块
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult Delete(long id);
        /// <summary>
        /// 移除主页
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult RemoveHomePage(long id);
        /// <summary>
        /// 指定系统可登陆的科室
        /// </summary>
        /// <param name="deptIds"></param>
        /// <returns></returns>
        DataResult SetLoginDeptList(long id, long[] deptIds);
        /// <summary>
        /// 获取指定系统可登陆的科室列表ID
        /// </summary>
        /// <param name="appIds"></param>
        /// <returns></returns>
        List<string> GetLoginDeptIdList(long appId);
        /// <summary>
        /// 获取指定系统下菜单列表ID
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        List<int> GetMenuIdList(long appId);
    }
}
