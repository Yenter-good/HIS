using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    public enum ChargeInvoiceType
    {
        [System.ComponentModel.Description("门诊发票")]
        门诊发票 = 0,
        [System.ComponentModel.Description("住院发票")]
        住院发票 = 1,
        [System.ComponentModel.Description("住院预交金收据")]
        住院预交金收据 = 2,
    }
}
