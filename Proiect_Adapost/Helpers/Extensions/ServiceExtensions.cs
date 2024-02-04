using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Repositories.ArhivaRepository;
using Proiect_Adapost.Repositories.ConditieRepository;
using Proiect_Adapost.Repositories.ControlRepository;
using Proiect_Adapost.Repositories.OrasRepository;
using Proiect_Adapost.Repositories.UserRepository;
using Proiect_Adapost.Services.AdapostService;
using Proiect_Adapost.Services.ArhivaService;
using Proiect_Adapost.Services.ConditieService;
using Proiect_Adapost.Services.ControlService;
using Proiect_Adapost.Services.OrasService;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Services.AnimalService;
using Proiect_Adapost.Repositories.Carnet_sanatateRepository;
using Proiect_Adapost.Services.Carnet_sanatateService;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Adapost.Repositories.ClientRepository;
using Proiect_Adapost.Services.ClientService;
using Proiect_Adapost.Repositories.AnimalClientRepository;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Services.AnimalClientService;
using Proiect_Adapost.Services.UserService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>() 

            services.AddTransient<ICarnet_sanatateRepository, Carnet_sanatateRepository>();
            services.AddTransient<IAdapostRepository, AdapostRepository>();
            services.AddTransient<IOrasRepository, OrasRepository>();
            services.AddTransient<IConditieRepository, ConditieRepository>();
            services.AddTransient<IControlRepository, ControlRepository>();
            services.AddTransient<IArhivaRepository, ArhivaRepository>();
            services.AddTransient<IAnimalRepository, AnimalRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IAnimalClientRepository, AnimalClientRepository >();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<IAdapostService, AdapostService>();
            services.AddTransient<IOrasService, OrasService>();
            services.AddTransient<IConditieService, ConditieService>();
            services.AddTransient<IControlService, ControlService>();
            services.AddTransient<IArhivaService, ArhivaService>();
            services.AddTransient<ICarnet_sanatateService, Carnet_sanatateService>();
            services.AddTransient<Proiect_Adapost.Services.AdapostService.IAdapostService, AdapostService>();
            services.AddTransient<Proiect_Adapost.Services.OrasService.IOrasService, OrasService>();
            services.AddTransient<IAnimalService, AnimalService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IAnimalClientService, AnimalClientService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }
    }
}
