using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.DataTransfer.Repository
{
    public interface IGenericRepository<TEntity> : IDisposable, IAsyncDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> GetByNameAsync(string name);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task AddAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        Task UpdateAsync(TEntity entity);
        Task UpdateAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
    }
}
