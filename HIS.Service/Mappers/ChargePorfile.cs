using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Model;
using HIS.Service.Core.Entities;

namespace HIS.Service.Mappers
{
    class ChargePorfile : Profile
    {
        public ChargePorfile() {
            //收费票据
            this.CreateMap<Charge_Invoice, ChargeInvoiceEntity>()
                .ReverseMap();

            //号费
            this.CreateMap<Reg_RegisteredFeeType, RegFeeType>()
                .ReverseMap();
        }
    }
}
