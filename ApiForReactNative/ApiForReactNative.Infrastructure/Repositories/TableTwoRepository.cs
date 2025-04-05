using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using ApiForReactNative.Infrastructure.Context;
using GenericRepository;

namespace ApiForReactNative.Infrastructure.Repositories
{
    internal sealed class TableTwoRepository : Repository<TableTwo, ApplicationDbContext>, ITableTwoRepository
    {
        public TableTwoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
