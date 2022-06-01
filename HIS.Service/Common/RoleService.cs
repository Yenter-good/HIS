using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:50:05
/// 功能:
/// </summary>
namespace HIS.Service
{
    public class RoleService : IRoleService
    {
        private readonly IIdService _idService;

        public RoleService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取指定用户拥有的所有角色
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<RoleEntity> GetByUser(long userId)
        {
            var model = DBHelper.Instance.HIS.FromSql($@"
select b.* from Sys_UserRoleMapper a
left join Sys_Role b on a.RoleId=b.Id
where a.UserId='{userId}'
").ToList<Sys_Role>();
            return AutoMapperHelper.Instance.Mapper.Map<List<RoleEntity>>(model);
        }

        /// <summary>
        /// 获取指定角色下的权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = HIS.Core.Cache.CacheKeys.IRoleService_GetAuthority)]
        public List<LongItem> GetAuthority(long roleId)
        {
            return DBHelper.Instance.HIS.From<Sys_RoleAuthority>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.RoleId == roleId).ToList().Select(p => new LongItem(p.Id, "", p.AuthorityCode)).ToList();
        }
        /// <summary>
        /// 获取指定角色下的权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<LongItem> GetAuthorityWithoutCache(long roleId)
        {
            return DBHelper.Instance.HIS.From<Sys_RoleAuthority>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.RoleId == roleId).ToList().Select(p => new LongItem(p.Id, "", p.AuthorityCode)).ToList();
        }

        /// <summary>
        /// 获得所有角色列表
        /// </summary>
        /// <returns></returns>
        public List<RoleEntity> GetAll()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<RoleEntity>>(DBHelper.Instance.HIS.From<Sys_Role>().ToList());
        }

        /// <summary>
        /// 给指定角色插入菜单
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuIds"></param>
        /// <returns></returns>
        public DataResult InsertMenus(long roleId, List<long> menuIds)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        batch.Delete<Sys_RoleMenuMapper>(new WhereClip(Sys_RoleMenuMapper._.RoleId, roleId, QueryOperator.Equal));
                        foreach (var id in menuIds)
                        {
                            var model = new Sys_RoleMenuMapper()
                            {
                                HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id,
                                Id = _idService.CreateUUID(),
                                MenuId = id,
                                RoleId = roleId
                            };
                            batch.Insert(model);
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
        /// 新增角色
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="leval"></param>
        /// <returns></returns>
        public DataResult<RoleEntity> Insert(string code, string name, string description, int leval)
        {
            var model = new Sys_Role()
            {
                Code = code,
                Name = name,
                Description = description,
                RoleLevel = leval
            };
            model.SetCreationValues();
            model.Id = _idService.CreateUUID();

            try
            {
                DBHelper.Instance.HIS.Insert(model);
                return DataResult.True(AutoMapperHelper.Instance.Mapper.Map<RoleEntity>(model));
            }
            catch (Exception ex)
            {
                return DataResult.Fault<RoleEntity>(ex.Message);
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {

                    tran.Delete<Sys_Role>(p => p.Id == id);
                    tran.Delete<Sys_UserRoleMapper>(p => p.RoleId == id);
                    tran.Delete<Sys_RoleMenuMapper>(p => p.RoleId == id);
                    tran.Delete<Sys_RoleAuthority>(p => p.RoleId == id);

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
        /// 给指定角色插入权限集
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="codes"></param>
        /// <returns></returns>
        public DataResult InsertPermission(long roleId, List<string> codes)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        batch.Delete<Sys_RoleAuthority>(new WhereClip(Sys_RoleAuthority._.RoleId, roleId, QueryOperator.Equal));
                        foreach (var code in codes)
                        {
                            var model = new Sys_RoleAuthority()
                            {
                                HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id,
                                Id = _idService.CreateUUID(),
                                AuthorityCode = code,
                                RoleId = roleId
                            };
                            batch.Insert(model);
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
        /// 删除指定角色下的用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataResult DeleteUser(long roleId, long userId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Sys_UserRoleMapper>(p => p.RoleId == roleId && p.UserId == userId);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 在指定角色下增加用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataResult InsertUser(long roleId, long userId)
        {
            try
            {
                var model = new Sys_UserRoleMapper()
                {
                    Id = _idService.CreateUUID(),
                    HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id,
                    RoleId = roleId,
                    UserId = userId
                };
                DBHelper.Instance.HIS.Insert(model);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取指定用户在指定角色下的附加信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public RoleAdditionalEntity GetAddition(long roleId, long userId)
        {
            var model = DBHelper.Instance.HIS.From<View_RoleAddition>().Where(p => p.UserId == userId && p.RoleId == roleId).First();
            if (model == null)
                return new RoleAdditionalEntity() { AllowEndTime = SqlDateTime.MinValue.Value.End() };

            return model.Mapper<RoleAdditionalEntity>();
        }
        /// <summary>
        /// 获得指定用户的所有角色附加信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<RoleAdditionalEntity> GetAllAddition(long userId)
        {
            var models = DBHelper.Instance.HIS.From<View_RoleAddition>().Where(p => p.UserId == userId).ToList();
            if (models.Count == 0)
                return new List<RoleAdditionalEntity>();

            return models.Mapper<List<RoleAdditionalEntity>>();
        }
    }
}
