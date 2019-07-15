using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Kanoon.DomainModels.Entities;
using Kanoon.DomainModels.Models.Heiat;

namespace Kanoon.Bootstraper.Mapping
{
    public class HeiatProfileMapping : Profile
    {
        public HeiatProfileMapping()
        {
            CreateMap<HeiatModel, Heiat>().ReverseMap();
        }
    }
}
