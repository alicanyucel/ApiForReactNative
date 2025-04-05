
using ApiForReactNative.WebAPI.Abstractions;
using MediatR;

namespace ApiForReactNative.WebAPI.Controllers;

public class TableThreeController : ApiController
{
    public TableThreeController(IMediator mediator) : base(mediator)
    {
    }
}
