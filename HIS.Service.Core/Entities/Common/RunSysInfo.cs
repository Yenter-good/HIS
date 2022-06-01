using System;
using System.Collections.Generic;
using HIS.Utility.Win32;

namespace HIS.Service.Core.Entities
{
    public class RunSysInfo
    {
        /// <summary>
        /// 当前运行系统模块信息
        /// </summary>
        public AppEntity AppInfo { get; internal set; }
        /// <summary>
        /// 当前用户信息
        /// </summary>
        public UserEntity UserInfo { get; internal set; }
        /// <summary>
        /// 当前医疗机构信息
        /// </summary>
        public OrganizationInfo HospitalInfo { get; internal set; }
        /// <summary>
        /// 该系统可被用于的科室
        /// </summary>
        public List<DeptEntity> DeptList { get; internal set; }
        /// <summary>
        /// 机器信息
        /// </summary>
        public MachineInfo MachineInfo { get; internal set; }

    }
}
