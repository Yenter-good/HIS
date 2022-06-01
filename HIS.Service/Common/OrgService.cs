using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class OrgService : IOrgService
    {

        public OrgService(IIniService iniService)
        {

        }
        /// <summary>
        /// 获取机构信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrganizationInfo Get(long id)
        {
            var org = DBHelper.Instance.HIS.From<Sys_Org>()
                .Where(d => d.Id == id).First();

            if (org == null) return null;
            return AutoMapperHelper.Instance.Mapper.Map<OrganizationInfo>(org);
        }
        /// <summary>
        /// 获取所有机构信息
        /// </summary>
        /// <returns></returns>
        public List<OrganizationInfo> GetAll()
        {

            return AutoMapperHelper.Instance.Mapper.Map<List<OrganizationInfo>>(DBHelper.Instance.HIS.From<Sys_Org>().ToList());
        }
    }
}
