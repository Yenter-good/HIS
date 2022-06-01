using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// id 生成服务
    /// </summary>
    public class IdService : IIdService
    {
        /// <summary>
        /// 根据GUID获取唯一数字序列
        /// </summary>
        public long CreateUUID()
        {
            byte[] bytes = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(bytes, 0);
        }
    }
}
