using DatingAppAPI.Data;
using DatingAppAPI.Interfaces;
using DatingAppAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:Default"]);
            });

            return services;
        }
    }
}
