using System;
using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url); })
            .ForMember(m => m.Age, opt => { opt.MapFrom(src => new DateTime(DateTime.Now.Subtract(src.DateOfBirth).Ticks).Year); });

            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoUrl, opt => { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url); })
            .ForMember(m => m.Age, opt => { opt.MapFrom(src => new DateTime(DateTime.Now.Subtract(src.DateOfBirth).Ticks).Year); });
            CreateMap<Photo, PhotoForDetailedDto>();
        }
    }
}