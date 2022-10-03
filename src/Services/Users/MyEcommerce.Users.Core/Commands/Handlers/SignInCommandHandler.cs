using MyEcommerce.Shared.Abstractions.Request;
using MyEcommerce.Shared.Infrastructure.Http;

namespace MyEcommerce.Users.Application.Commands.Handlers;

internal sealed class SignInCommandHandler : IHttpRequestHandler<SignInCommand>
{
    public async Task<IHttpResult> Handle(
        SignInCommand req,
        CancellationToken ct 
    )
    {
        return Results.Ok("elo");
    }
}
