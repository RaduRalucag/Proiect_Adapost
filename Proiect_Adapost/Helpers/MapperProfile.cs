﻿using AutoMapper;
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
            CreateMap<Adapost, AdapostResponseDto>();
            CreateMap<Animal, AnimalResponseDto>();
            CreateMap<AnimalRequestDto, Animal>();
            CreateMap<Adapost, AdapostRequestDto>();
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
            CreateMap<Oras, OrasResponseDto>();
            CreateMap<OrasRequestDto, Oras>();
            CreateMap<Carnet_sanatate, Carnet_sanatateResponseDto>()
                .ForMember(dest => dest.numeAnimal, opt => opt.MapFrom(src => src.Animal.Nume));
            CreateMap<Carnet_sanatateRequestDto, Carnet_sanatate>();
            CreateMap<Client, ClientResponseDto>();
            CreateMap<ClientRequestDto, Client>();
            CreateMap<AnimalClient, AnimalClientResponseDto>();
            CreateMap<AnimalClientRequestDto, AnimalClient>();
            
            CreateMap<Arhiva, ArhivaResponseDto>();
            CreateMap<ArhivaRequestDto, Arhiva>();
        }
       
    
    }
}
