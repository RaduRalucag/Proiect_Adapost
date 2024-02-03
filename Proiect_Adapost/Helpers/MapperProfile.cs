﻿using AutoMapper;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Adapost.DTO;
using Proiect_Adapost.Models.Oras.DTO;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Animal.Dto;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Models.Carnet_sanatate.Dto;
using Proiect_Adapost.Models.Client.Dto;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Models.AnimalClient.Dto;
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
            CreateMap<Carnet_sanatate, Carnet_sanatateResponseDto>()
                .ForMember(dest => dest.numeAnimal, opt => opt.MapFrom(src => src.Animal.Nume));
            CreateMap<Carnet_sanatateRequestDto, Carnet_sanatate>();
            CreateMap<Client, ClientResponseDto>();
            CreateMap<ClientRequestDto, Client>();
            CreateMap<AnimalClient, AnimalResponseDto>();
            CreateMap<AnimalClientRequestDto, AnimalClient>();
            
        }
       
    
    }
}
