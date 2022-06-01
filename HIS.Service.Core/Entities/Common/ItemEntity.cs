using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    [Serializable]
    public class ItemEntity
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }


        public string SearchCode { get; set; }
        public DataStatus Status { get; set; }
        public override string ToString()
        {
            return Value ?? base.ToString();
        }
        public LongItem ToLongItem()
        {
            return new LongItem(this.Id, this.Value, this.Code);
        }
    }
}
