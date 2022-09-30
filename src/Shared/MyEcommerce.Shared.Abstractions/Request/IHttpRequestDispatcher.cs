using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Shared.Abstractions.Request;

public interface IHttpRequestDispatcher
{
    Task<IResult> Send(
        IHttpRequest req,
        CancellationToken ct = default
    );
}