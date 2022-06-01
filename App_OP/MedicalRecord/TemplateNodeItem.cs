using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-24 15:50:39
    /// 描述:
    /// </summary>
    public class TemplateNodeItem
    {
        /// <summary>
        /// 编码Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// xml内容
        /// </summary>
        public string XML { get; set; }
    }
}
