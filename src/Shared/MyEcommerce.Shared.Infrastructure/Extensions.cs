using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Shared.Infrastructure.Request;

namespace MyEcommerce.Shared.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureCore(this IServiceCollection services)
    {

        return services;
    }

    public static IApplicationBuilder UseInfrastructureCore(this IApplicationBuilder app)
    {
        app
            .UseSwagger()
            .UseRouting()
            .UseAuthentication()
            .UseAuthorization();

        return app;
    }

    public static T BindOptions<T>(this IConfigurationSection section) where T : new()
    {
        var options = new T();
        section.Bind(options);
        return options;
    }
}