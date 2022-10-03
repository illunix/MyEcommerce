using MyEcommerce.Shared.Abstractions.Request;
using MyEcommerce.Shared.Infrastructure.Http.Attributes;

namespace MyEcommerce.Users.Application.Commands;

[POST]
internal readonly record struct SignInCommand(
    string Email,
    string Password
) : IHttpRequest;
