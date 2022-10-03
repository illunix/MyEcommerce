using MyEcommerce.Shared.Abstractions.Request;

namespace MyEcommerce.Shared.Infrastructure.Http;

public static class Results
{
    public static IHttpResult Ok(object value)
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.Ok(value);

    public static Microsoft.AspNetCore.Http.IResult BadRequest()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.BadRequest();

    public static Microsoft.AspNetCore.Http.IResult NotFound()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.NotFound();

    public static Microsoft.AspNetCore.Http.IResult Unauthorized()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.Unauthorized();

    public static Microsoft.AspNetCore.Http.IResult NoContent()
        => (IHttpResult)Microsoft.AspNetCore.Http.Results.NoContent();
}