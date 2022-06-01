using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HIS.Core
{
    /// <summary>
    /// 登陆用户信息
    /// </summary>
    public class LoginUser
    {
        private IUserService _userService;
        private IAppService _appService;
        private UserEntity _userInfo;
        private IRoleService _roleService;
        private Teacher _teacher = null;
        /// <summary>
        /// 获取用户编号
        /// </summary>
        public long? Id { get { return _userInfo?.Id; } }
        /// <summary>
        /// 获取用户工号
        /// </summary>
        public string UserCode { get { return _userInfo?.Code; } }
        /// <summary>
        /// 获取用户姓名
        /// </summary>
        public string UserName { get { return _userInfo?.Name; } }
        /// <summary>
        /// 获取用户当前角色
        /// </summary>
        public RoleEntity Role { get; set; }
        /// <summary>
        /// 当前角色附加信息
        /// </summary>
        public RoleAdditionalEntity RoleAddition { get; set; }
        /// <summary>
        /// 获取用户类型
        /// </summary>
        public UserType UserType { get { return _userInfo.UserType; } }
        /// <summary>
        /// 用户性质
        /// </summary>
        public UserNature UserNature { get { return _userInfo.UserNature; } }
        /// <summary>
        /// 职称
        /// </summary>
        public TitleEntity Title
        {
            get
            {
                return _userInfo.Title;
            }
        }
        /// <summary>
        /// 签名图片
        /// </summary>
        public Image Autograph { get; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telphone { get; set; }
        /// <summary>
        /// 获取带教老师信息
        /// 仅实习类用户才有带教老师信息
        /// </summary>
        public Teacher Teacher
        {
            get
            {
                if (_userInfo != null && _userInfo.RoleAdditions.Count > 0)
                {
                    var roleAddition = _userInfo.RoleAdditions.Find(p => p.Role.Id == this.Role.Id);
                    if (roleAddition == null)
                        return null;
                    if (_teacher != null && roleAddition.Teacher.Id == _teacher.UserId)
                        return _teacher;
                    _teacher = new Teacher(_userService.Get(roleAddition.Teacher.Id));
                    return _teacher;

                }
                return null;
            }
        }

        /// <summary>
        /// 获取当前用户下指定系统模块支持的科室列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        internal List<DeptEntity> GetDeptListByApp(long appId)
        {
            return _userService.GetDeptListByApp(appId);
        }
        /// <summary>
        /// 获取当前用户当前系统下模块包含的菜单列表
        /// </summary>
        /// <returns></returns>
        public List<MenuEntity> GetMenuList()
        {
            //if (App.Instance.RuntimeSystemInfo.DeptList == null || App.Instance.RuntimeSystemInfo.DeptList.Count == 0)
            //    return new List<MenuEntity>();
            return _userService.GetMenuList(_userInfo, App.Instance.RuntimeSystemInfo.AppInfo.Id);
        }

        /// <summary>
        /// 获取当前用户支持的系统模块列表
        /// </summary>
        public List<AppEntity> AppList { get; private set; }

        internal LoginUser(UserEntity userEntity, RoleEntity roleEntity)
        {
            userEntity.CheckNotNull(nameof(userEntity));
            this._userService = ServiceLocator.GetService<IUserService>();
            this._appService = ServiceLocator.GetService<IAppService>();
            this._roleService = ServiceLocator.GetService<IRoleService>();
            this._userInfo = userEntity;
            this.RoleAddition = _roleService.GetAddition(roleEntity.Id, userEntity.Id);
            this.Role = roleEntity;
            if (_userInfo == null)
                throw new System.ArgumentException($"不存在工号{_userInfo.Code}的用户信息");
            //获取用户支持的系统列表
            var appList = _userService.GetAppList(_userInfo, roleEntity.Id);
            if (appList == null || appList.Count == 0)
                throw new System.ArgumentException($"{_userInfo.Code}的用户在{roleEntity.Name}权限下无相关系统模块的授权");
            this.AppList = appList;
        }

        /// <summary>
        /// 判断当前角色下是否拥有指定权限
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool HasPermission(string code)
        {
            var permissions = _roleService.GetAuthority(this.Role.Id);
            if (permissions.Exists(p => p.Code == code))
                return true;

            return false;
        }
    }
    /// <summary>
    /// 带教老师信息
    /// </summary>
    public class Teacher
    {
        private UserEntity _userInfo = null;
        /// <summary>
        /// 获取用户编号
        /// </summary>
        public long? UserId { get { return _userInfo?.Id; } }
        /// <summary>
        /// 获取用户工号
        /// </summary>
        public string UserCode { get { return _userInfo?.Code; } }
        /// <summary>
        /// 获取用户姓名
        /// </summary>
        public string UserName { get { return _userInfo?.Name; } }
        /// <summary>
        /// 获取用户类型
        /// </summary>
        public UserType UserType { get { return _userInfo.UserType; } }
        /// <summary>
        /// 用户性质
        /// </summary>
        public UserNature UserNature { get { return _userInfo.UserNature; } }
        /// <summary>
        /// 职称
        /// </summary>
        public TitleEntity Title
        {
            get
            {
                return _userInfo.Title;
            }
        }
        /// <summary>
        /// 签名图片
        /// </summary>
        public Image Autograph { get; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telphone { get; set; }

        public Teacher(UserEntity userEntity)
        {
            this._userInfo = userEntity;
        }

    }
}
