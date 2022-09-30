using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Shared.Infrastructure.Request;

public sealed class HttpRequestDispatcher : IHttpRequestDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public HttpRequestDispatcher(IServiceProvider serviceProvider)
        => _serviceProvider = serviceProvider;

    public async Task<IResult> Send(
        IHttpRequest req,
        CancellationToken ct = default
    )
    {
        using var scope = _serviceProvider.CreateScope();
        var handlerType = typeof(IHttpRequestHandler<>).MakeGenericType(
            req.GetType(),
            typeof(IResult)
        );
        var handler = scope.ServiceProvider.GetRequiredService(handlerType);
        var method = handlerType.GetMethod(nameof(IHttpRequestHandler<IHttpRequest>.Handle));
        if (method is null)
        {
            throw new InvalidOperationException($"Http request handler for '{typeof(IResult).Name}' is invalid.");
        }

        return await (Task<IResult>)method.Invoke(
            handler,
            new object[] { req, ct }
        );
    }
}