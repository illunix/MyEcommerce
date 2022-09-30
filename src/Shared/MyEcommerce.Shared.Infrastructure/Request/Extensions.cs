using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Shared.Infrastructure.Request;

public static class Extensions
{
    public static IServiceCollection AddHttpRequests(
        this IServiceCollection services,
        Type type
    )
    {
        services.AddSingleton<IHttpRequestDispatcher, HttpRequestDispatcher>();
        services.Scan(q => q.FromAssemblies(type.Assembly)
            .AddClasses(q => q.AssignableTo(typeof(IHttpRequestHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}