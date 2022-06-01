using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class RegFeeType
    {
        public long Id { set; get; }
        public string Code { set; get; }

        public string Name { set; get; }
        public string PriceItemCode { set; get; }
        public double Price { set; get; }
    }
}
