using AutoMapper;
using NewsWebsite.Application.DTO.Newses;



namespace NewsWebsite.Application.Features;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NewsDTO, Domains.Entities.News>();
        CreateMap<Domains.Entities.News, NewsDTO>();
    }

}
