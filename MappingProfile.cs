﻿using AutoMapper;
using GMTVendorEvaluationWebApp.Models;

namespace IdentityByExamples
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
