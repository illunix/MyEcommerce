using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Users.Application.Commands;

internal readonly record struct SignInCommand(
    string Email,
    string Password
) : IHttpRequest;