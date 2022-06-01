using HIS.Core;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-18 11:54:50
    /// 描述:
    /// </summary>
    [ServiceId("SqlServer")]
    public class LogService : ILogService
    {
        public void Write(string action, string operationClassFullName, string description, string parameterValue, string result, string level)
        {
            Sys_Log model = new Sys_Log();
            model.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
            model.SessionId = App.Instance.SessionId;
            model.CreationTime = DBHelper.Instance.ServerTime;
            model.Action = action;
            model.ClassFullName = operationClassFullName;
            model.Description = description;
            model.ParameterValue = parameterValue;
            model.ResultValue = result;
            model.Level = level;

            try
            {
                DBHelper.Instance.HIS.Insert(model);
            }
            catch
            {
            }
        }
    }
}
