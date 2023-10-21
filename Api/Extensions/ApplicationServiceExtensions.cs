
using Api.Interfaces;
using Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection
         services, IConfiguration config)
        {

            services.AddDbContext<DataContext>(opt =>
              {
                  opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
              });

            services.AddCors();

            services.AddScoped<ITokenService, TokenService>();

            return services;

        }
    }
}