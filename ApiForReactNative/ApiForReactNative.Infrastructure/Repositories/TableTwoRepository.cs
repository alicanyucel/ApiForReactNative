using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using ApiForReactNative.Infrastructure.Context;
using GenericRepository;

namespace ApiForReactNative.Infrastructure.Repositories;

internal sealed class TableTwoRepository : Repository<TableIki, ApplicationDbContext>, ITableTwoRepository
{
    public TableTwoRepository(ApplicationDbContext context) : base(context)
    {
    }
}
