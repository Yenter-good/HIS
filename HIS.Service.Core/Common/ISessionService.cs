using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-16 12:40:59
    /// 描述:
    /// </summary>
    public interface ISessionService : IServiceSingleton
    {
        /// <summary>
        /// 生成当次session
        /// </summary>
        /// <returns></returns>
        DataResult<long> Generate();
        /// <summary>
        /// 尝试释放session
        /// </summary>
        void Release();
    }
}
