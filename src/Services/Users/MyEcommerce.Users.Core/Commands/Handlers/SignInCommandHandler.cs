using Microsoft.AspNetCore.Http;
using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Users.Application.Commands.Handlers;

internal sealed class SignInCommandHandler : IHttpRequestHandler<SignInCommand>
{
    public async Task<IResult> Handle(
        SignInCommand req,
        CancellationToken ct 
    )
    {
        return Results.Ok("elo");
    }
}
