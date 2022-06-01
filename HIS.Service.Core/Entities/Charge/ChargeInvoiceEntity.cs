using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
	public class ChargeInvoiceEntity
    {
		public long Id { get; set; }
		public int Type { get; set; }
		public long CashierId { get; set; }
		public string CashierCode { get; set; }
		public string CashierName { get; set; }
		public string BeginInvoiceNo { get; set; }
		public string EndInvoiceNo { get; set; }
		public string CurrentInvoiceNo { get; set; }
	}
}
