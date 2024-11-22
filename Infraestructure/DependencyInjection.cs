using Application.Interfaces;

using Infraestructure.DataBase;
using Infraestructure.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string cadenaConexion = configuration.GetConnectionString("DefaultConnection")!;
            services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(cadenaConexion));

            services.AddScoped<IPersonaRepository, PersonaRepository>();
            return services;
        }
    }
}
