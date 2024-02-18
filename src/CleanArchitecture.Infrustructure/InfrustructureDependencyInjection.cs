using CleanArchitecture.Infrustructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArchitecture.Infrustructure
{
    public static class InfrustructureDependencyInjection
    {
        public static IServiceCollection AddInfrustructureDependency(this IServiceCollection services,IConfiguration configuration)
        {
            var assembly = typeof(InfrustructureDependencyInjection).Assembly;

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(assembly);
            });

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            });

            return services;
        }
    }
}
