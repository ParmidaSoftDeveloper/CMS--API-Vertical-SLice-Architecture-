using AutoMapper;
using Dtos.Articles.Get;

namespace Geekiam.Api.Activities.Articles.Queries.GetAll;

public class Mapping: Profile
{
    public Mapping()
    {
    
       CreateMap<Models.Cms.Content, Article>(MemberList.None)
           .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
           .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Body))
           .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary));
           
           
    }
}
