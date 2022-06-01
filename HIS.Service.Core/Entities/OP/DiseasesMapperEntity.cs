using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class DiseasesMapperEntity: DrugInventoryEntity
    {
        public long Id { set; get; }

        public long DiseaseId { set; get; }
    }
}
