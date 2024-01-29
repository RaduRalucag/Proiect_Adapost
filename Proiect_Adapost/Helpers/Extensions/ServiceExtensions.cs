using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Services.AdapostService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            services.AddTransient<IAdapostRepository, AdapostRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<IAdapostService, AdapostService>();
            return services;
        }
    }
}
