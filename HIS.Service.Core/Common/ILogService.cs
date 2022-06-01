using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-18 11:53:15
    /// 描述:
    /// </summary>
    public interface ILogService : IServiceSingleton
    {
        void Write(string action,string operationClassFullName, string description, string parameterValue, string result, string level);
    }
}
