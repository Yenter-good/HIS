using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Sys.User
{
    internal interface IUserRoleInfo
    {
        /// <summary>
        /// 当前角色
        /// </summary>
        RoleEntity Role { get; }
        /// <summary>
        /// 获取角色附加信息
        /// </summary>
        /// <returns></returns>
        RoleAdditionalEntity GetRoleAddition(bool mandatoryGet = false);
        /// <summary>
        /// 获得科室信息
        /// </summary>
        /// <returns></returns>
        List<DeptEntity> GetDepts(bool mandatoryGet = false);
    }
}
