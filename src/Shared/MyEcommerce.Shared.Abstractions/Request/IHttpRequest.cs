﻿using Microsoft.AspNetCore.Http;

namespace MyEcommerce.Shared.Abstractions.Request;

public interface IHttpRequest : IRequest<IResult> { }