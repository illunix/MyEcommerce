using FluentValidation;
using MyEcommerce.Shared.Infrastructure.Request;

namespace MyEcommerce.Users.API;

internal static class Extensions
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services
            .AddHttpRequests(typeof(Program))
            .AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .AddValidatorsFromAssemblyContaining<Program>();

        return services;
    }
}