using AutoMapper;
using Cinema.Entities;
using Cinema.DTOs;  
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Movie, MovieCreateDto>().ReverseMap();
        CreateMap<Movie, MovieEditDto>().ReverseMap();
    }
}
