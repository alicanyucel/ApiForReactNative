﻿using ApiForReactNative.Domain.Entities;
using ApiForReactNative.Domain.Repositories;
using ApiForReactNative.Infrastructure.Context;
using GenericRepository;


namespace ApiForReactNative.Infrastructure.Repositories;

internal sealed class TableThreeRepository : Repository<TableUc, ApplicationDbContext>, ITableThreeRepository
{
    public TableThreeRepository(ApplicationDbContext context) : base(context)
    {
    }
}
