using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class DeptPharmacyEntity : DeptEntity
    {
        public long aid { set; get; }
        public long DeptId { set; get; }
        public long PharmacyId { set; get; }
    }
}
