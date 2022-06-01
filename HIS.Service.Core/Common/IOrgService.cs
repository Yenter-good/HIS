using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 机构服务
    /// </summary>
    public interface IOrgService : IServiceSingleton
    {
       
        /// <summary>
        /// 获取机构信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrganizationInfo Get(long id);
        /// <summary>
        /// 获取所有机构信息
        /// </summary>
        /// <returns></returns>
        List<OrganizationInfo> GetAll();
    }
}
