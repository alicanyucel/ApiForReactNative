using ApiForReactNative.WebAPI.Abstractions;
using MediatR;

namespace ApiForReactNative.WebAPI.Controllers;

public class TableOneController : ApiController
{
    public TableOneController(IMediator mediator) : base(mediator)
    {
    }
}
