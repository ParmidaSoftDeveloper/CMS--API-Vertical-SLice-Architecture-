using AutoMapper;
using Dtos.Articles.Get;

namespace Geekiam.Api.Activities.Articles.Queries.GetbyId;

public class Mapping: Profile
{
    public Mapping()
    {
       
        CreateMap<Models.Cms.Article, Article>(MemberList.None)
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));
    }
}
