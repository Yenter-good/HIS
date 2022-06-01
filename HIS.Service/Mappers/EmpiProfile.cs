using AutoMapper;
using HIS.Model;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Mappers
{
    class EmpiProfile : Profile
    {
        public EmpiProfile()
        {       
            //行政区划
            this.CreateMap<Empi_Address, AdministrativeDivisionEntity>()
                .ReverseMap();
            //患者主索引
            this.CreateMap<Empi_PatientIndex, PatientEntity>()
                .ReverseMap();
        }
     

    }
}
