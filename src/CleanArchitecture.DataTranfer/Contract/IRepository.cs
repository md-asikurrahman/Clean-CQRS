﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.DataTranfer.Contract
{
    public interface IRepository<TEntity ,in TKey> : IDisposable, IAsyncDisposable where TEntity : class, IEntity<TKey>
    where TKey : IComparable<TKey>
    {
        Task<TEntity> GetByIdAsync();
        Task<TEntity> AddAsync(TEntity entity,CancellationToken cancellationToken = default);
        Task<TEntity> UpdateAsync(TEntity entity,CancellationToken cancellationToken = default);
    }
}
