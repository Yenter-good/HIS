using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:49:34
/// 功能:
/// </summary>
namespace HIS.Service
{
    public class UserService : IUserService
    {
        private IIdService _idService;
        private IRoleService _roleService;
        public UserService(IIdService idService, IRoleService roleService)
        {
            _idService = idService;
            _roleService = roleService;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity Get(long id)
        {
            var user = DBHelper.Instance.HIS.From<Sys_User>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id)
                .First();
            if (user != null)
            {
                return AutoMapperHelper.Instance.Mapper.Map<UserEntity>(user);
            }
            return null;
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity Get(long id, long roleId)
        {
            var user = DBHelper.Instance.HIS.From<View_User>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id && d.RoleId == roleId)
                .First();
            if (user != null)
            {
                return user.Mapper<UserEntity>();
            }
            return null;
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> GetAll()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<UserEntity>>(DBHelper.Instance.HIS.From<Sys_User>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList());
        }
        /// <summary>
        /// 获取所有用户，带权限信息
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> GetAllWithRole()
        {
            return DBHelper.Instance.HIS.From<View_User>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<UserEntity>>();
        }
        /// <summary>
        /// 获取系统模块列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<AppEntity> GetAppList(UserEntity user, long roleId)
        {
            return DBHelper.Instance.HIS.FromSql(@"
select distinct d.Id,d.Name,d.HomePage,d.No from Sys_UserRoleMapper a
left join Sys_RoleMenuMapper b on a.RoleId=b.RoleId
left join Sys_Menu c on b.MenuId=c.Id
left join Sys_App d on c.AppId=d.Id
where a.UserId=@uid and a.HosId=@hid and b.RoleId=@rid")
.AddInParameter("@uid", System.Data.DbType.String, user.Id)
.AddInParameter("@hid", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
.AddInParameter("@rid", System.Data.DbType.Int64, roleId)
.ToList<Sys_App>()
.Select(d => d.Mapper<AppEntity>()).ToList();
        }

        /// <summary>
        /// 验证账号密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserEntity ValidationAccount(string account, string password)
        {
            if (!DBHelper.Instance.HIS.Exists<Sys_User>(p => p.Code == account && p.Password == password && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id))
                return null;

            return DBHelper.Instance.HIS.From<Sys_User>().Where(p => p.Code == account && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<UserEntity>();
        }

        /// <summary>
        /// 获取用户当前系统下授权科室列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<DeptEntity> GetDeptListByApp(long appId)
        {
            var list = AutoMapperHelper.Instance.Mapper.Map<List<DeptEntity>>(DBHelper.Instance.HIS.FromSql(@"
select b.* from Sys_UserDeptMapper a 
left join View_Dept b on a.DeptId=b.Id
where a.UserId=@uid and a.HosId=@hid and a.RoleId=@rid and exists(select * from Sys_AppDeptMapper where AppId=@appid and DeptId in (a.DeptId))
order by b.No
")
 .AddInParameter("@uid", System.Data.DbType.String, App.Instance.User.Id)
 .AddInParameter("@hid", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
 .AddInParameter("@appid", System.Data.DbType.Int64, appId)
 .AddInParameter("@rid", System.Data.DbType.Int64, App.Instance.User.Role.Id)
 .ToList<View_Dept>());
            return list.DistinctBy(p => p.Id).ToList();
        }
        /// <summary>
        /// 获取用户授权的菜单列表
        /// </summary>
        /// <param name="user"></param>
        /// <param name="appId"></param>
        /// <param name="deptIds"></param>
        /// <returns></returns>
        public List<MenuEntity> GetMenuList(UserEntity user, long appId)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<MenuEntity>>(
                DBHelper.Instance.HIS.FromSql($@"select c.* from Sys_UserRoleMapper a
left join Sys_RoleMenuMapper b on a.RoleId=b.RoleId
left join Sys_Menu c on b.MenuId=c.Id
where a.UserId=@uid and c.AppId=@appid and a.RoleId=@rid and a.HosId=@hid and exists(select * from Sys_RoleMenuMapper where MenuId = c.Id) order by c.No")
 .AddInParameter("@uid", System.Data.DbType.String, user.Id)
 .AddInParameter("@appid", System.Data.DbType.String, appId)
 .AddInParameter("@hid", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
 .AddInParameter("@rid", System.Data.DbType.Int64, App.Instance.User.Role.Id)
 .ToList<Sys_Menu>());
        }

        /// <summary>
        /// 获取指定角色下所有用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<UserEntity> GetByRole(long roleId)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<UserEntity>>(DBHelper.Instance.HIS.From<Sys_UserRoleMapper>().LeftJoin<Sys_User>((p, d) => p.UserId == d.Id).Where(p => p.RoleId == roleId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(Sys_User._.All).ToList<Sys_User>());
        }

        /// <summary>
        /// 获取指定科室下的用户
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<UserEntity> GetByDept(long deptId)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<UserEntity>>(DBHelper.Instance.HIS.From<Sys_User>().LeftJoin<Sys_UserDeptMapper>((p, d) => p.Id == d.UserId).Where(Sys_UserDeptMapper._.DeptId == deptId && Sys_User._.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(Sys_User._.All).ToList<Sys_User>());
        }
        /// <summary>
        /// 停用指定用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataResult DisableUser(long userId)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_User>();
                modify[Sys_User._.DataStatus] = DataStatus.Disable;

                DBHelper.Instance.HIS.Update<Sys_User>(modify, p => p.Id == userId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 启用指定用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataResult EnableUser(long userId)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<Sys_User>();
                modify[Sys_User._.DataStatus] = DataStatus.Enable;

                DBHelper.Instance.HIS.Update<Sys_User>(modify, p => p.Id == userId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="additionEntities"></param>
        /// <returns></returns>
        public DataResult UpdateUser(long userId, UserEntity userEntity, Dictionary<RoleAdditionalEntity, List<DeptEntity>> roleAdditional)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //如果传了用户实体，则更新用户基本信息
                        if (userEntity != null)
                        {
                            var userModify = AuditionHelper.GetModificationValues<Sys_User>();
                            userModify[Sys_User._.Name] = userEntity.Name;
                            userModify[Sys_User._.Code] = userEntity.Code;
                            userModify[Sys_User._.UserType] = (int)userEntity.UserType;
                            userModify[Sys_User._.TitleId] = userEntity.Title?.TitleId;
                            userModify[Sys_User._.UserNature] = (int)userEntity.UserNature;
                            userModify[Sys_User._.EducationId] = userEntity.Education?.Key;
                            userModify[Sys_User._.RoleId] = userEntity.Role?.Id;
                            userModify[Sys_User._.IDCard] = userEntity.IDCard;
                            userModify[Sys_User._.Birthday] = userEntity.Birthday;
                            userModify[Sys_User._.PhoneNumber] = userEntity.PhoneNumber;
                            userModify[Sys_User._.Password] = userEntity.Password.AsString("");
                            batch.Update<Sys_User>(userModify, new WhereClip(Sys_User._.Id, userId, QueryOperator.Equal).And(new WhereClip(Sys_User._.HosId, App.Instance.RuntimeSystemInfo.HospitalInfo.Id, QueryOperator.Equal)));
                        }

                        foreach (var item in roleAdditional)
                        {
                            //更新用户角色附加信息表
                            var additionEntity = item.Key;
                            var depts = item.Value;

                            if (additionEntity.DataOperation == Core.Enums.DataOperation.Modify)
                            {
                                var additionModify = AuditionHelper.GetModificationValues<Sys_RoleAdditionalInfo>();
                                additionModify[Sys_RoleAdditionalInfo._.AllowStartTime] = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowStartTime.TimeOfDay.Ticks);
                                additionModify[Sys_RoleAdditionalInfo._.AllowEndTime] = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowEndTime.TimeOfDay.Ticks);
                                additionModify[Sys_RoleAdditionalInfo._.TeacherId] = additionEntity.Teacher?.Id;
                                additionModify[Sys_RoleAdditionalInfo._.DefaultDeptId] = additionEntity.DefaultDept?.Id;
                                batch.Update<Sys_RoleAdditionalInfo>(additionModify,
                                    new WhereClip(Sys_RoleAdditionalInfo._.UserId, userId, QueryOperator.Equal)
                                    .And(new WhereClip(Sys_RoleAdditionalInfo._.RoleId, additionEntity.Role.Id, QueryOperator.Equal))
                                    .And(new WhereClip(Sys_RoleAdditionalInfo._.HosId, App.Instance.RuntimeSystemInfo.HospitalInfo.Id, QueryOperator.Equal)));
                            }
                            else if (additionEntity.DataOperation == Core.Enums.DataOperation.New)
                            {
                                var additionInsert = new Sys_RoleAdditionalInfo().SetCreationValues();
                                additionInsert.Id = _idService.CreateUUID();
                                additionInsert.AllowStartTime = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowStartTime.TimeOfDay.Ticks);
                                additionInsert.AllowEndTime = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowEndTime.TimeOfDay.Ticks);
                                additionInsert.TeacherId = additionEntity.Teacher?.Id;
                                additionInsert.DefaultDeptId = additionEntity.DefaultDept?.Id;
                                additionInsert.RoleId = additionEntity.Role.Id;
                                additionInsert.UserId = userId;
                                batch.Insert<Sys_RoleAdditionalInfo>(additionInsert);
                            }

                            //如果存在科室信息，则更新用户和科室关系表

                            if (depts != null)
                            {
                                //删除指定角色下的科室信息，插入新的科室信息
                                batch.Delete<Sys_UserDeptMapper>(new WhereClip(Sys_UserDeptMapper._.UserId, userId, QueryOperator.Equal).And(new WhereClip(Sys_UserDeptMapper._.RoleId, additionEntity.Role.Id, QueryOperator.Equal)));
                                foreach (var dept in depts)
                                {
                                    var deptInsert = new Sys_UserDeptMapper();
                                    deptInsert.Id = _idService.CreateUUID();
                                    deptInsert.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                                    deptInsert.UserId = userId;
                                    deptInsert.DeptId = dept.Id;
                                    deptInsert.RoleId = additionEntity.Role.Id;
                                    batch.Insert(deptInsert);
                                }
                            }
                        }
                    }

                    tran.Commit();
                    return DataResult.True();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    return DataResult.Fault(ex.Message);
                }
            }
        }
        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="userEntity"></param>
        /// <param name="additionEntities"></param>
        /// <returns></returns>
        public DataResult InsertUser(UserEntity userEntity)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        var insert = userEntity.Mapper<Sys_User>();
                        userEntity.Id = _idService.CreateUUID();
                        insert.Id = userEntity.Id;
                        insert.SetCreationValues();

                        batch.Insert<Sys_User>(insert);

                        //foreach (var item in roleAdditional)
                        //{
                        //    //更新用户角色附加信息表
                        //    var additionEntity = item.Key;
                        //    var depts = item.Value;


                        //    var additionInsert = new Sys_RoleAdditionalInfo().SetCreationValues();
                        //    additionInsert.Id = _idService.CreateUUID();
                        //    additionInsert.AllowStartTime = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowStartTime.TimeOfDay.Ticks);
                        //    additionInsert.AllowEndTime = SqlDateTime.MinValue.Value.AddTicks(additionEntity.AllowEndTime.TimeOfDay.Ticks);
                        //    additionInsert.TeacherId = additionEntity.Teacher?.Id;
                        //    additionInsert.DefaultDeptId = additionEntity.DefaultDept?.Id;
                        //    batch.Insert<Sys_RoleAdditionalInfo>(additionInsert);

                        //    foreach (var dept in depts)
                        //    {
                        //        var deptInsert = new Sys_UserDeptMapper();
                        //        deptInsert.Id = _idService.CreateUUID();
                        //        deptInsert.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                        //        deptInsert.UserId = userEntity.Id;
                        //        deptInsert.DeptId = dept.Id;
                        //        deptInsert.RoleId = additionEntity.Role.Id;
                        //        batch.Insert(deptInsert);
                        //    }
                        //}
                    }

                    tran.Commit();
                    return DataResult.True();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    return DataResult.Fault(ex.Message);
                }
            }
        }
        /// <summary>
        /// 用户工号是否已存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ExistCode(string code)
        {
            return DBHelper.Instance.HIS.Exists<Sys_User>(p => p.Code == code && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
        }

    }
}
