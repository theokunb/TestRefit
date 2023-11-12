using AutoMapper;
using TestRestClient.Models.Dto;
using TestRefit.Request.Word.Create;

namespace TestRefit.Mapper
{
    public class WordProfile : Profile
    {
        public WordProfile()
        {
            CreateMap<WordDto, CreateWord>()
                .ForMember(destination => destination.Value, conf => conf.MapFrom(source => source.Value)).ReverseMap();
            CreateMap<CreateWord, Entity.Word>()
                .ForMember(destination => destination.Value, config => config.MapFrom(source => source.Value)).ReverseMap();
        }
    }
}
