using HIS.Core;
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


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 15:49:49
/// 功能:
/// </summary>
namespace HIS.Service
{
    public class AppService : IAppService
    {
        private IIdService _idService;
        public AppService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取系统模块列表
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<AppEntity> GetList(bool includeDisable = false)
        {
            if (includeDisable)
                return DBHelper.Instance.HIS.From<Sys_App>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete).OrderBy(a => a.No).ToList()
                  .Select(d => d.Mapper<AppEntity>()).ToList();
            return DBHelper.Instance.HIS.From<Sys_App>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable).OrderBy(a => a.No).ToList()
                .Select(d => d.Mapper<AppEntity>()).ToList();
        }

        /// <summary>
        /// 插入系统模块
        /// </summary>
        /// <param name="appEntity"></param>
        /// <param name="enable"></param>
        /// <returns></returns>
        public AppEntity Insert(AppEntity appEntity)
        {
            appEntity.CheckNotNull(nameof(appEntity));
            appEntity.Name.CheckNotNullOrEmpty(nameof(appEntity.Name));

            var defaultDept = DBHelper.Instance.HIS.From<Sys_Dept>().Where(p => p.Code == "DefaultSystem").First();

            var appModel = appEntity.Mapper<Sys_App>();
            appModel.Id = this._idService.CreateUUID();
            appModel.SetCreationValues();
            DBHelper.Instance.HIS.Insert(appModel);
            appEntity.Id = appModel.Id;

            if (defaultDept != null)
            {
                var appDeptMapper = new Sys_AppDeptMapper();
                appDeptMapper.Id = _idService.CreateUUID();
                appDeptMapper.AppId = appEntity.Id;
                appDeptMapper.DeptId = defaultDept.Id;
                appDeptMapper.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                DBHelper.Instance.HIS.Insert(appDeptMapper);
            }

            return appEntity;
        }
        /// <summary>
        /// 更新系统模块信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="appEntity"></param>
        /// <returns></returns>
        public DataResult Update(long id, AppEntity appEntity)
        {
            appEntity.CheckNotNull(nameof(appEntity));
            var appModel = DBHelper.Instance.HIS.From<Sys_App>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id).First();
            if (appModel == null || appModel.DataStatus == (int)DataStatus.Delete)
                return DataResult.Fault("当前系统模块不存在");
            AutoMapperHelper.Instance.Mapper.Map(appEntity, appModel);
            appModel.Id = id;
            if (!appModel.IsModify())
                return DataResult.True();
            appModel.SetModificationValues();
            DBHelper.Instance.HIS.Update(appModel);
            return DataResult.True();
        }
        /// <summary>
        /// 删除系统模块
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataResult Delete(long id)
        {
            if (DBHelper.Instance.HIS.Exists<Sys_Menu>(d => d.AppId == id && d.DataStatus != (int)DataStatus.Delete))
                return DataResult.Fault("当前系统中包含有菜单项信息,不允许删除");
            var updateValues = AuditionHelper.GetDeletionValues<Sys_App>();
            DBHelper.Instance.HIS.Update<Sys_App>(updateValues, d => d.Id == id);
            return DataResult.True();
        }
        /// <summary>
        /// 移除主页
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataResult RemoveHomePage(long id)
        {
            var updateValues = AuditionHelper.GetModificationValues<Sys_App>();
            updateValues[Sys_App._.HomePage] = null;
            DBHelper.Instance.HIS.Update<Sys_App>(updateValues, d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == id);
            return DataResult.True();
        }
        /// <summary>
        /// 设置系统模块的登陆科室
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deptIds"></param>
        /// <returns></returns>
        public DataResult SetLoginDeptList(long id, long[] deptIds)
        {
            if (deptIds == null || deptIds.Length == 0)
                DBHelper.Instance.HIS.Delete<Sys_AppDeptMapper>(Sys_AppDeptMapper._.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && Sys_AppDeptMapper._.AppId == id);
            else
            {
                var operDateTime = DBHelper.Instance.ServerTime;
                using (var batch = DBHelper.Instance.HIS.BeginBatchConnection())
                {
                    batch.Delete<Sys_AppDeptMapper>(Sys_AppDeptMapper._.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && Sys_AppDeptMapper._.AppId == id);
                    int no = 0;
                    foreach (var deptId in deptIds)
                    {
                        var Sys_AppDeptMapper = new Sys_AppDeptMapper();
                        Sys_AppDeptMapper.SetCreationValues(operDateTime);
                        Sys_AppDeptMapper.Id = this._idService.CreateUUID();
                        Sys_AppDeptMapper.AppId = id;
                        Sys_AppDeptMapper.DeptId = deptId;
                        Sys_AppDeptMapper.HosId = HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                        Sys_AppDeptMapper.No = no;
                        batch.Insert(Sys_AppDeptMapper);
                        no++;
                    }
                }
            }
            return DataResult.True();

        }
        /// <summary>
        /// 获取指定系统可登陆的科室列表
        /// </summary>
        /// <param name="appIds"></param>
        /// <returns></returns>
        public List<string> GetLoginDeptIdList(long appId)
        {
            return DBHelper.Instance.HIS.From<Sys_AppDeptMapper>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.AppId == appId).Select(d => d.DeptId).ToList<string>();
        }
        /// <summary>
        /// 获取指定系统下菜单列表ID
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public List<int> GetMenuIdList(long appId)
        {
            return DBHelper.Instance.HIS.From<Sys_Menu>().Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.AppId == appId).Select(d => d.Id).ToList<int>();
        }
    }
}
