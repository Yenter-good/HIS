using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-02 11:28:50
    /// 描述:
    /// </summary>
    public class PrescriptionTypeEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public PrscriptionType Type { get; set; }
        public DrugCategory Category { get; set; }
        public int No { get; set; }
    }
}
