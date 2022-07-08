using AutoMapper;
using Dtos.Articles.Patch;

namespace Geekiam.Api.Activities.Articles.Commands.Patch;

public class Mapping: Profile
{
    public Mapping()
    {
        
        
        CreateMap<Models.Cms.Article, Response>(MemberList.None)
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));
 
        CreateMap<Models.Cms.Article, Article>(MemberList.None)
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));

        CreateMap<Article, Models.Cms.Article>(MemberList.None)
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));

    }
}
