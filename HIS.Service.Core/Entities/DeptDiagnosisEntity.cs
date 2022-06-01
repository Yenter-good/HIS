using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class DeptDiagnosisEntity: DiagnosisEntity
    {
        public long Id { set; get; }
        public long DeptId { set; get; }
    }
}
