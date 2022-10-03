using MyEcommerce.Shared.Abstractions.Request;
using MyEcommerce.Shared.Infrastructure.Request;
using MyEcommerce.Users.DAL.Context;

namespace MyEcommerce.Users.Application.Commands.Handlers;

internal sealed class SignInCommandHandler : HttpRequestHandler<SignInCommand>
{
    private readonly UsersDbContext _ctx;

    public SignInCommandHandler(UsersDbContext ctx)
        => _ctx = ctx;

    public override async Task<IHttpResult> Handle(
        SignInCommand req,
        CancellationToken ct 
    )
    {
        return Ok();
    }
}
