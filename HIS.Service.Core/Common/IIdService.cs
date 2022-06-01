using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// id 生成服务
    /// </summary>
    public interface IIdService : IServiceSingleton
    {
        /// <summary>
        /// 生成唯一ID
        /// </summary>
        /// <returns></returns>
        long CreateUUID();
    }
}
