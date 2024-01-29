using AutoMapper;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Animal.Dto;
namespace Proiect_Adapost.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Animal, AnimalResponseDto>();
            CreateMap<AnimalRequestDto, Animal>();
            CreateMap<Adapost, AdapostRequestDto>();
            CreateMap<AdapostRequestDto, Adapost>();
            CreateMap<Oras, OrasDto>();
            CreateMap<OrasDto, Oras>();
        }
       
    
    }
}
