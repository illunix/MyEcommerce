using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyEcommerce.Shared.Infrastructure.Postgres;

public static class Extensions
{
    public static IServiceCollection AddPostgres<T>(
        this IServiceCollection services, 
        IConfiguration configuration
    ) where T : DbContext
    {
        var section = configuration.GetSection("postgres");
        var options = section.BindOptions<PostgresOptions>();

        services.AddDbContext<T>(x => x.UseNpgsql(options.ConnectionString));

        return services;
    }
}