using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Shared.Abstractions.Request;

public interface IHttpRequestHandler<TRequest> 
{
    Task<IHttpResult> Handle(
        TRequest req,
        CancellationToken ct = default
    );
}