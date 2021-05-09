using AutoMapper;
using SchoolManagement.Entities;
using SchoolManagement.Infrastructure.Authentication;
using SchoolManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Infrastructure
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegistrationRequest, RequestViewModel>(); 
            CreateMap<RequestInputModel, RegistrationRequest>().ForMember(x => x.HashPassword, opt => opt.MapFrom(x => x.Password)); 
            
            CreateMap<ApplicationUser, UserViewModel>(); 
        }
    }
}
