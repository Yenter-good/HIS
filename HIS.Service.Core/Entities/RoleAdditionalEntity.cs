using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class RoleAdditionalEntity
    {
        /// <summary>
        /// 角色信息
        /// </summary>
        public RoleEntity Role { get; set; }
        /// <summary>
        /// 带教老师
        /// </summary>
        public UserEntity Teacher { get; set; }
        /// <summary>
        /// 允许登录时间
        /// </summary>
        public DateTime AllowStartTime { get; set; }
        /// <summary>
        /// 允许登陆截止的时间
        /// </summary>
        public DateTime AllowEndTime { get; set; }
        /// <summary>
        /// 默认科室
        /// </summary>
        public DeptEntity DefaultDept { get; set; }

        /// <summary>
        /// 数据操作状态
        /// </summary>
        public DataOperation DataOperation { get; set; }
    }
}
