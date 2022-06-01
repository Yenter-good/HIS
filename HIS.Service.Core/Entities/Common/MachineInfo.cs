using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// MachineInfo
    /// 获取硬件信息的部分
    /// </summary>
    public class MachineInfo
    {
        /// <summary>
        /// 计算机名称
        /// </summary>
        public string ComputeName { get; set; }
        /// <summary>
        /// 客户端ID
        /// </summary>
        public string ClientIP { get; set; }
        /// <summary>
        /// 网卡MAC
        /// </summary>
        public string ClientMAC { get; set; }
        /// <summary>
        /// CPU编号
        /// </summary>
        public string CPUSerialNo { get; set; }
        /// <summary>
        /// 硬盘编号
        /// </summary>
        public string HardDiskInfo { get; set; }
    }
}
