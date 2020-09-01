using AutoMapper;
using Uspeak.Data.Models;

namespace Uspeak.Infrastructure.Mapping
{
    public class UspeakProfile : Profile
    {
        public UspeakProfile()
        {
            CreateMap<Tag, Data.Dto.Tag>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.CssClass, o => o.MapFrom(s => s.CssClass));
        }
    }
}
