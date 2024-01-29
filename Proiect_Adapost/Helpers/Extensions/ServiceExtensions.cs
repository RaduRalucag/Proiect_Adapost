using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Repositories.OrasRepository;
using Proiect_Adapost.Services.AdapostService;
using Proiect_Adapost.Services.OrasService;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Services;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            services.AddTransient<IAdapostRepository, AdapostRepository>();
            services.AddTransient<IOrasRepository, OrasRepository>();
            services.AddTransient<IAnimalRepository, AnimalRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<Proiect_Adapost.Services.AdapostService.IAdapostService, AdapostService>();
            services.AddTransient<Proiect_Adapost.Services.OrasService.IOrasService, OrasService>();
            services.AddTransient<IAnimalService, AnimalService>();
            return services;
        }
    }
}
