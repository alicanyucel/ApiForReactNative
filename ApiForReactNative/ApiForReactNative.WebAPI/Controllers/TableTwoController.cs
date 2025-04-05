
using ApiForReactNative.WebAPI.Abstractions;
using MediatR;

namespace ApiForReactNative.WebAPI.Controllers;

public class TableTwoController : ApiController
{
    public TableTwoController(IMediator mediator) : base(mediator)
    {
    }
}
