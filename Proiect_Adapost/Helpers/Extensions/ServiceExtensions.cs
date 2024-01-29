using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Services;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
           
            
            services.AddTransient<IAnimalRepository, AnimalRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
       
            services.AddTransient<IAnimalService, AnimalService>();
            return services;
        }
    }
}
