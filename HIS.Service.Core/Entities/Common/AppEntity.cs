using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class AppEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 系统名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 系统状态
        /// </summary>
        public DataStatus Status { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
    }
}
