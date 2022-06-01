using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities.OP
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-03 09:38:23
    /// 描述:
    /// </summary>
    public class PrescriptionDrugDetailEntity : PrescriptionDetailEntity
    {
        public DrugEntity Drug { get; set; }
    }
}
