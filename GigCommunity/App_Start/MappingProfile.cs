using AutoMapper;
using GigCommunity.Core.Dtos;
using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigCommunity.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<ApplicationUser, UserDto>();
            //    cfg.CreateMap<Gig, GigDto>();
            //    cfg.CreateMap<Notification, NotificationDto>();
            //});


        }
    }
}