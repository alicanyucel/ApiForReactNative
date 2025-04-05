
using ApiForReactNative.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace ApiForReactNative.WebAPI.Controllers;

[AllowAnonymous]

public class TableTwoController : ApiController
{
    public TableTwoController(IMediator mediator) : base(mediator)
    {
    }
}
