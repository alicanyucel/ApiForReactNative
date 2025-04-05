using ApiForReactNative.Application.Features.TableOne.CreateTableOnes;
using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ApiForReactNative.Application.Features;

internal sealed class CreateTableOneCommandHandler(ITableOneRepository tableOneRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<TableOneCreateCommand, Result<string>>
{
    public ITableOneRepository TableOneRepository { get; } = tableOneRepository;

    public async Task<Result<string>> Handle(TableOneCreateCommand request, CancellationToken cancellationToken)
    {
        TableBir tableBir = mapper.Map<TableBir>(request);
        await TableOneRepository.AddAsync(tableBir, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Table 1 Added";
    }
}
