using AutoMapper;
using TestRestClient.Models;
using TestRestClient.Models.Dto;
using TestWebApi.Entity;
using TestWebApi.Models.Dto;

namespace TestWebApi.Mapper
{
    public class ObserverProfile : Profile
    {
        public ObserverProfile() 
        {
            CreateMap<Word, Observer>()
                .ForMember(destination => destination.Word, conf => conf.MapFrom(source => source.Value))
                .ForMember(destination => destination.SuperWord, conf => conf.MapFrom(source => source.Value.ToUpper()));
            CreateMap<ObserverDto, WordDto>()
                .ForMember(destination => destination.Value, conf => conf.MapFrom(source => source.Value));
        }
    }
}
