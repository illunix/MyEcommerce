using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Shared.Abstractions.Request;

public interface IRequest<TResult> where TResult : class, IResult { }