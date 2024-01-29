using AutoMapper;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Animal.Dto;
namespace Proiect_Adapost.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<AnimalRequestDto, Animal>();
        }
    }
}
