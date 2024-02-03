using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Repositories.OrasRepository;
using Proiect_Adapost.Services.AdapostService;
using Proiect_Adapost.Services.OrasService;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Services.AnimalService;
using Proiect_Adapost.Repositories.Carnet_sanatateRepository;
using Proiect_Adapost.Services.Carnet_sanatateService;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Adapost.Repositories.ClientRepository;
using Proiect_Adapost.Services.ClientService;

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
            services.AddTransient<IAnimalRepository, AnimalRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<ICarnet_sanatateService, Carnet_sanatateService>();
            services.AddTransient<Proiect_Adapost.Services.AdapostService.IAdapostService, AdapostService>();
            services.AddTransient<Proiect_Adapost.Services.OrasService.IOrasService, OrasService>();
            services.AddTransient<IAnimalService, AnimalService>();
            services.AddTransient<IClientService, ClientService>();
            return services;
        }
    }
}
