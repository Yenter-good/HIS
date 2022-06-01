using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 医疗机构信息
    /// </summary>
    [DisplayName("医疗机构信息")]
    public class OrganizationInfo
    {
        /// <summary>
        /// 系统id
        /// </summary>
        [DisplayName("机构id")]
        public long Id { get; set; }
        /// <summary>
        /// 内部机构编码
        /// </summary>
        [DisplayName("机构内部编码")]
        public string Code { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        [DisplayName("机构名称")]
        public string Name { get; set; }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        [DisplayName("组织机构代码")]
        public string OrganizationCode { get; set; }
    }
}
