using AutoMapper;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Models.Arhiva.DTO;
using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Models.Conditie.DTO;
using Proiect_Adapost.Models.Control;
using Proiect_Adapost.Models.Control.DTO;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Orase;
namespace Proiect_Adapost.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Adapost, AdapostResponseDto>()
                .ForMember(dest => dest.NumeOras, opt => opt.MapFrom(src => src.Oras.Nume))
                .ForMember(dest => dest.NumeConditie, opt => opt.MapFrom(src => src.Conditie.Denumire))
                .ForMember(dest => dest.OrasId, opt => opt.MapFrom(src => src.Oras.Id))
                .ForMember(dest => dest.ConditieId, opt => opt.MapFrom(src => src.Conditie.Id));
            CreateMap<AdapostRequestDto, Adapost>();
            CreateMap<Oras, OrasResponseDto>()
                .ForMember(dest => dest.NumeAdaposturi, opt => opt.MapFrom(src => src.Adaposts.Select(a => a.Nume)));
            CreateMap<OrasRequestDto, Oras>();
            CreateMap<Conditie, ConditieResponseDto>();
            CreateMap<ConditieRequestDto, Conditie>();
            CreateMap<Control, ControlResponseDto>();
            CreateMap<ControlRequestDto, Control>();
            CreateMap<Arhiva, ArhivaResponseDto>();
            CreateMap<ArhivaRequestDto, Arhiva>();
        }
    }
}
