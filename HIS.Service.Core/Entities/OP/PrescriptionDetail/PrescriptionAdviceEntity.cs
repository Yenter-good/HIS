using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-03-04 10:14:42
    /// 描述:
    /// </summary>
    public class PrescriptionAdviceEntity : AdviceEntity
    {
        /// <summary>
        /// 执行科室
        /// </summary>
        public DeptEntity ExecDept { get; set; }
    }
}
