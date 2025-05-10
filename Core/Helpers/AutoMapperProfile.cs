using AutoMapper;
using Core.DTOs;
using Data.Entities;

namespace Core.Helpers;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Movie, MovieCreateDto>().ReverseMap();
        CreateMap<Movie, MovieEditDto>().ReverseMap();
    }
}
