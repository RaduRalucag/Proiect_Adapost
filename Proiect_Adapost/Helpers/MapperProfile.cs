using AutoMapper;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Orase;
namespace Proiect_Adapost.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Adapost, AdapostResponseDto>();
            CreateMap<AdapostRequestDto, Adapost>();
            CreateMap<Oras, OrasDto>()
                .ForMember(dest => dest.NumeAdaposturi, opt => opt.MapFrom(src => src.Adaposts.Select(a => a.Nume)));
            CreateMap<OrasRequestDto, Oras>();
        }
    }
}
