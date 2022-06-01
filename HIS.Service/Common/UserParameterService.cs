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
    public class UserParameterService : IUserParameterService
    {
        private IIdService _idService;
        public UserParameterService(IIdService idService)
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
            string value = DBHelper.Instance.HIS.From<Sys_UserParameter>()
                                .Select(s => s.ParameterValue)
                                .Where(s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && s.UserId == App.Instance.User.Id)
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
                Sys_UserParameter param = new Model.Sys_UserParameter();
                param.Id = this._idService.CreateUUID();
                param.ParameterCode = code.ToUpper();
                param.ParameterName = name ?? code;
                param.ParameterValue = value.BeginJsonSerializable();
                param.SearchCode = name.GetSpell();
                param.PropertyName = propertyName;
                param.Description = memo;
                param.CreatorUserId = App.Instance.User.Id.Value;
                param.CreationTime = DBHelper.Instance.ServerTime;
                param.LastModifierUserId = param.CreatorUserId;
                param.LastModificationTime = param.CreationTime;
                param.DataStatus = (int)DataStatus.Enable;
                param.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                param.UserId = App.Instance.User.Id.Value;
                DBHelper.Instance.HIS.Insert<Sys_UserParameter>(param);
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
            return DBHelper.Instance.HIS.Exists<Sys_UserParameter>(s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && s.UserId == App.Instance.User.Id);
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
            updateValues[Sys_UserParameter._.LastModificationTime] = DBHelper.Instance.ServerTime;
            updateValues[Sys_UserParameter._.LastModifierUserId] = App.Instance.User.Id;
            updateValues[Sys_UserParameter._.ParameterValue] = parameterValue;
            return DBHelper.Instance.HIS.Update<Sys_UserParameter>(updateValues, s => s.ParameterCode == code.ToUpper() && s.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && s.UserId == App.Instance.User.Id) > 0;
        }
        /// <summary>
        /// 获取全部用户参数
        /// </summary>
        /// <returns></returns>
        public DataResult<List<UserParameterEntity>> GetAll()
        {
            try
            {
                List<UserParameterEntity> sysParameterEntitys = DBHelper.Instance.HIS.From<Sys_UserParameter>()
                    .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete && d.UserId == App.Instance.User.Id)
                    .OrderBy(d => d.No)
                    .ToList<Sys_Parameter>()
                    .Mapper<List<UserParameterEntity>>();

                return DataResult.True<List<UserParameterEntity>>(sysParameterEntitys);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<UserParameterEntity>>(ex.Message);
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
            Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_UserParameter>();
            updateValue[Sys_UserParameter._.DataStatus] = (int)dataStatus;
            bool result = DBHelper.Instance.HIS.Update<Sys_UserParameter>(updateValue, d => d.Id == id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.UserId == App.Instance.User.Id) > 0;

            return result;
        }
        /// <summary>
        /// 更新用户参数
        /// </summary>
        /// <param name="sysParameterEntity">用户参数实体</param>
        /// <returns></returns>
        public DataResult Update(UserParameterEntity sysParameterEntity)
        {
            try
            {
                Dictionary<Field, object> updateValue = AuditionHelper.GetModificationValues<Sys_UserParameter>();
                updateValue[Sys_UserParameter._.ParameterValue] = sysParameterEntity.ParameterValue;
                updateValue[Sys_UserParameter._.Description] = sysParameterEntity.Description;
                updateValue[Sys_UserParameter._.DataStatus] = sysParameterEntity.DataStatus;

                DBHelper.Instance.HIS.Update<Sys_UserParameter>(updateValue, d => d.Id == sysParameterEntity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.UserId == App.Instance.User.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
