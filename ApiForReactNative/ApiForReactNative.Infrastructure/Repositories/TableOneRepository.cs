using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using ApiForReactNative.Infrastructure.Context;
using GenericRepository;


namespace ApiForReactNative.Infrastructure.Repositories;

internal sealed class TableOneRepository : Repository<TableBir, ApplicationDbContext>, ITableOneRepository
{
    public TableOneRepository(ApplicationDbContext context) : base(context)
    {

    }

}
