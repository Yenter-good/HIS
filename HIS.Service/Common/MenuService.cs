using Dos.ORM;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class MenuService : IMenuService
    {
        private IIdService _idService;
        public MenuService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<MenuEntity> GetList(long appId, bool includeDisable = false)
        {
            if (includeDisable)
                return AutoMapperHelper.Instance.Mapper.Map<List<MenuEntity>>(DBHelper.Instance.HIS.From<Sys_Menu>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.AppId == appId && d.DataStatus != (int)DataStatus.Delete)
                    .OrderBy(a => a.No)
                    .ToList());
            return AutoMapperHelper.Instance.Mapper.Map<List<MenuEntity>>(DBHelper.Instance.HIS.From<Sys_Menu>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable && d.AppId == appId)
                .OrderBy(a => a.No).ToList());
        }

        /// <summary>
        /// 获取菜单分类
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public List<MenuEntity> GetCategoryList(long appId)
        {
            return DBHelper.Instance.HIS.From<Sys_Menu>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.AppId == appId && d.ParentId == 0 && d.DataStatus == (int)DataStatus.Enable).OrderBy(a => a.No).ToList()
                  .Select(d => AutoMapperHelper.Instance.Mapper.Map<MenuEntity>(d)).ToList();
        }

        /// <summary>
        /// 插入菜单
        /// </summary>
        /// <param name="appId">系统ID</param>
        /// <param name="menu">菜单信息</param>
        /// <returns></returns>
        public MenuEntity Insert(long appId, MenuEntity menu)
        {
            if (appId < 0)
                throw new ArgumentException(nameof(appId));
            menu.CheckNotNull(nameof(menu));
            var menuModel = AutoMapperHelper.Instance.Mapper.Map<Sys_Menu>(menu);
            menuModel.AppId = appId;
            menuModel.Id = this._idService.CreateUUID();
            menuModel.Code = Guid.NewGuid().ToString();
            menuModel.SetCreationValues();
            menuModel.DataStatus = (int)DataStatus.Enable;
            menuModel.InitParam = menu.InitParam;
            DBHelper.Instance.HIS.Insert(menuModel);
            menu.Id = menuModel.Id;
            return menu;
        }

        /// <summary>
        /// 更新菜单
        /// </summary>
        /// <param name="menuId">菜单编号</param>
        /// <param name="menu">菜单信息</param>
        /// <returns></returns>
        public DataResult Update(long menuId, MenuEntity menu)
        {
            menu.CheckNotNull(nameof(menu));
            var menuModel = DBHelper.Instance.HIS.From<Sys_Menu>().Where(d => d.Id == menuId).First();
            if (menuModel == null || menuModel.DataStatus == (int)DataStatus.Delete)
                return DataResult.Fault("当前菜单不存在");
            AutoMapperHelper.Instance.Mapper.Map(menu, menuModel);
            menuModel.Id = menuId;
            if (!menuModel.IsModify())
                return DataResult.True();
            menuModel.SetModificationValues();

            //判断系统ID是否更新
            if (menuModel.GetModifyFieldsStr().Exists(d => d == Sys_Menu._.AppId.PropertyName))
            {
                //同步更新当前菜单中子菜单系统编号
                using (var trans = DBHelper.Instance.HIS.BeginTransaction())
                {
                    trans.Update(menuModel);
                    Dictionary<Field, object> updateValues = new Dictionary<Field, object>();
                    updateValues[Sys_Menu._.AppId] = menuModel.AppId;
                    updateValues[Sys_Menu._.LastModificationTime] = menuModel.LastModificationTime;
                    updateValues[Sys_Menu._.LastModifierUserId] = menuModel.LastModifierUserId;
                    trans.Update<Sys_Menu>(updateValues, d => d.ParentId == menuModel.Id);
                    trans.Commit();
                }
            }
            else
            {
                //否则直接更新
                DBHelper.Instance.HIS.Update(menuModel);
            }
            return DataResult.True();
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public DataResult Delete(long menuId)
        {
            var updateValues = AuditionHelper.GetDeletionValues<Sys_Menu>();
            DBHelper.Instance.HIS.Update<Sys_Menu>(updateValues, d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && (d.Id == menuId || d.ParentId == menuId) && d.DataStatus != (int)DataStatus.Delete);
            return DataResult.True();
        }

        /// <summary>
        /// 根据角色id获得菜单实体
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<MenuEntity> GetByRole(long roleId)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<MenuEntity>>(DBHelper.Instance.HIS.From<Sys_RoleMenuMapper>().LeftJoin<Sys_Menu>((p, d) => p.MenuId == d.Id).Where(p => p.RoleId == roleId).OrderBy(Sys_Menu._.No).Select(Sys_Menu._.All).ToList<Sys_Menu>());
        }
    }
}
