using AutoMapper;
using Dtos.Articles.Post;

namespace  Geekiam.Api.Activities.Articles.Commands.Post;

public class Mapping: Profile
{
    public Mapping()
    {


        CreateMap<Article, Models.Cms.Article>(MemberList.None)
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));

        CreateMap<Models.Cms.Article, Response>(MemberList.None)
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
