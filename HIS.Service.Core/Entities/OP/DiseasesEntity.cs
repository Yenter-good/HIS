using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class DiseasesEntity
    {
        public long Id { set; get; }

        public string Code { set; get; }
        public string Name { set; get; }

        public int Type { set; get; }
        public string SearchCode { set; get; }
        public string WubiCode { set; get; }
        
    }
}
