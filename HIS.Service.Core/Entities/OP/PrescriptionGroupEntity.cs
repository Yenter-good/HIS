using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class PrescriptionGroupEntity
    {
        public long Id { set; get; }
        public long ParentId { set; get; }

        public int GroupType { set; get; }

        public long OwnerId { set; get; }

        public string Name { set; get; }

        public int No { set; get; }
    }
}
