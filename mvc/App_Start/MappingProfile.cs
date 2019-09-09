﻿using AutoMapper;
using mvc.Dtos;
using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();


        }
        
    }
}