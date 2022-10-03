using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Shared.Infrastructure.Request;

public abstract class HttpRequestHandler<TRequest> : IHttpRequestHandler<TRequest> 
{
    public abstract Task<IHttpResult> Handle(
        TRequest req,
        CancellationToken ct
    );

    public IHttpResult Ok()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.Ok();

    public IHttpResult Ok(object value)
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.Ok(value);

    public IHttpResult BadRequest()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.BadRequest();

    public IHttpResult NotFound()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.NotFound();

    public IHttpResult Unauthorized()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.Unauthorized();

    public IHttpResult NoContent()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.NoContent();
}