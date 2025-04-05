
using ApiForReactNative.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace ApiForReactNative.WebAPI.Controllers;

[AllowAnonymous]

public class TableThreeController : ApiController
{
    public TableThreeController(IMediator mediator) : base(mediator)
    {
    }
}
