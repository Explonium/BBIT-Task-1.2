using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BBIT_Task_1._2.Entities;
using BBIT_Task_1._2.Models;

namespace BBIT_Task_1._2.Profiles
{
    public class TenantProfile : Profile
    {
        public TenantProfile()
        {
            CreateMap<TenantPostModel, Tenant>();
        }
    }
}
