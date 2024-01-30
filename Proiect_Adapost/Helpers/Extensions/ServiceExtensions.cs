using Microsoft.AspNetCore.Authorization;
using Proiect_Adapost.Repositories.AdapostRepository;
using Proiect_Adapost.Repositories.ArhivaRepository;
using Proiect_Adapost.Repositories.ConditieRepository;
using Proiect_Adapost.Repositories.ControlRepository;
using Proiect_Adapost.Repositories.OrasRepository;
using Proiect_Adapost.Services.AdapostService;
using Proiect_Adapost.Services.ArhivaService;
using Proiect_Adapost.Services.ConditieService;
using Proiect_Adapost.Services.ControlService;
using Proiect_Adapost.Services.OrasService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            services.AddTransient<IAdapostRepository, AdapostRepository>();
            services.AddTransient<IOrasRepository, OrasRepository>();
            services.AddTransient<IConditieRepository, ConditieRepository>();
            services.AddTransient<IControlRepository, ControlRepository>();
            services.AddTransient<IArhivaRepository, ArhivaRepository>();
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
            return services;
        }
    }
}
