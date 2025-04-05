using ApiForReactNative.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace ApiForReactNative.WebAPI.Controllers;

[AllowAnonymous]

public class TableOneController : ApiController
{
    public TableOneController(IMediator mediator) : base(mediator)
    {
    }
}
