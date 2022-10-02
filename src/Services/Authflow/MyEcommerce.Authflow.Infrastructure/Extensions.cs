using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Shared.Infrastructure.Postgres;
using MyEcommerce.Users.DAL.Context;

namespace MyEcommerce.Users.DAL;

public static class Extensions
{
    public static IServiceCollection AddDAL(
        this IServiceCollection services,
        IConfiguration config
    )
        => services
            .AddPostgres<UsersDbContext>(config);
}