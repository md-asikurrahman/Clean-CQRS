using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.DataTransfer.Repository
{
    public interface IGenericRepository<TEntity> : IDisposable, IAsyncDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? includes = null);
        Task<TEntity?> GetByIdAsync(Expression<Func<TEntity,bool>> predicate,Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? includes = null);
        Task<TEntity> GetByNameAsync(string name);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task AddAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        Task UpdateAsync(TEntity entity);
        Task UpdateAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        Task DeleteAsync(Expression<Func<TEntity,bool>> predicate);
        Task DeleteAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
    }
}
