using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Utility;
using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Enums;
using HIS.Service.Core.Entities;

namespace HIS.Service
{
    /// <summary>
    /// 系统参数服务
    /// </summary>
    public class SystemParameterService : ISystemParameterService
    {
        private IIdService _idService;
        public SystemParameterService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取指定名称的参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <returns></returns>
        public T Get<T>(string code)
        {
            code.CheckNotNullOrEmpty(nameof(code));
            string value = DBHelper.Instance.HIS.From<Sys_Parameter>()
                                .Select(s => s.ParameterValue)
                                .Where(s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                .ToScalar<string>();
            if (value.IsNullOrWhiteSpace())
                return default(T);
            try
            {
                return value.BeginJsonDeserialize<T>();
            }
            catch
            {
                return default(T);
            }
        }
        /// <summary>
        /// 获取指定名称的参数值
        /// 当不存在时系统自动添加改参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="memo"></param>
        /// <returns></returns>

        public T GetOrAdd<T>(string code, T value, string name, string propertyName, string memo = null)
        {
            code.CheckNotNullOrEmpty(nameof(code));
            if (this.Exist(code))
            {
                return Get<T>(code);
            }
            else
            {
                if (value == null)
                    return value;
                Sys_Parameter param = new Model.Sys_Parameter();
                param.Id = this._idService.CreateUUID();
                param.ParameterCode = code.ToUpper();
                param.ParameterName = name ?? code;
                param.ParameterValue = value.BeginJsonSerializable();
                param.SearchCode = code.GetSpell();
                param.PropertyName = propertyName;
                param.Description = memo;
                param.CreatorUserId = App.Instance.User.Id.Value;
                param.CreationTime = DBHelper.Instance.ServerTime;
                param.LastModifierUserId = param.CreatorUserId;
                param.LastModificationTime = param.CreationTime;
                param.DataStatus = (int)DataStatus.Enable;
                param.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                DBHelper.Instance.HIS.Insert<Sys_Parameter>(param);
                return value;
            }
        }
        /// <summary>
        /// 判断是否存在指定参数
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Exist(string code)
        {
            return DBHelper.Instance.HIS.Exists<Sys_Parameter>(s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
        }
        /// <summary>
        /// 更新指定编码参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Update<T>(string code, T value)
        {
            code.CheckNotNullOrEmpty(nameof(code));
            string parameterValue = null;
            if (value != null)
            {
                try
                {
                    parameterValue = value.BeginJsonSerializable();

                }
                catch
                {
                }
            }
            Dictionary<Field, object> updateValues = new Dictionary<Field, object>();
            updateValues[Sys_Parameter._.LastModificationTime] = DBHelper.Instance.ServerTime;
            updateValues[Sys_Parameter._.LastModifierUserId] = App.Instance.User.Id;
            updateValues[Sys_Parameter._.ParameterValue] = parameterValue;
            return DBHelper.Instance.HIS.Update<Sys_Parameter>(updateValues, s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id) > 0;
        }
        /// <summary>
        /// 获取全部系统参数
        /// </summary>
        /// <returns></returns>
        public DataResult<List<SysParameterEntity>> GetAll()
        {
            try
            {
                List<SysParameterEntity> sysParameterEntitys = DBHelper.Instance.HIS.From<Sys_Parameter>()
                    .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete)
                    .OrderBy(d => d.No)
                    .ToList<Sys_Parameter>()
                    .Mapper<List<SysParameterEntity>>();

                return DataResult.True<List<SysParameterEntity>>(sysParameterEntitys);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<SysParameterEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 更新数据状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>

        public bool UpdateDataStatusById(long id, DataStatus dataStatus)
        {
            Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_Parameter>();
            updateValue[Sys_Parameter._.DataStatus] = (int)dataStatus;
            bool result = DBHelper.Instance.HIS.Update<Sys_Parameter>(updateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id) > 0;

            return result;
        }
        /// <summary>
        /// 更新系统参数
        /// </summary>
        /// <param name="sysParameterEntity">系统参数实体</param>
        /// <returns></returns>
        public DataResult Update(SysParameterEntity sysParameterEntity)
        {
            try
            {
                Dictionary<Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_Parameter>();
                updateValue[Sys_Parameter._.ParameterValue] = sysParameterEntity.ParameterValue;
                updateValue[Sys_Parameter._.Description] = sysParameterEntity.Description;
                updateValue[Sys_Parameter._.DataStatus] = sysParameterEntity.DataStatus;

                DBHelper.Instance.HIS.Update<Sys_Parameter>(updateValue, d => d.Id == sysParameterEntity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
