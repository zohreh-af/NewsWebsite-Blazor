using AutoMapper;
using NewsWebsite.Application.DTO.Newses;
using NewsWebsite.Domains.Entities;

namespace NewsWebsite.Application.Features;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NewsDTO, News>();
        CreateMap<News, NewsDTO>();
    }

}
