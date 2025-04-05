

using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiForReactNative.Application.Features.TableOne.GetAllTableOne;
internal sealed class GetAllTableOneQueryHandler : IRequestHandler<GetAllTableOneQuery, List<TableBir>>
{
    private readonly ITableOneRepository _tableOneRepository;

    public GetAllTableOneQueryHandler(ITableOneRepository tableOneRepository)
    {
        _tableOneRepository = tableOneRepository;
    }

    public async Task<List<TableBir>> Handle(GetAllTableOneQuery request, CancellationToken cancellationToken)
    {
        return await _tableOneRepository.GetAll().OrderBy(p => p.ProjeAdi).ToListAsync(cancellationToken);
    }
}