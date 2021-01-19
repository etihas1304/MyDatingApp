using AutoMapper;
using DatingApp.Dtos;
using DatingApp.Entities;
using DatingApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
             src.Photos.FirstOrDefault(x => x.IsMain).Url))
             .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.BirthDate.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>()/*.ForMember(dest=>dest.Introductin,opt=>opt.MapFrom(src=>src.Introduction))*/;
        }
    }
}
