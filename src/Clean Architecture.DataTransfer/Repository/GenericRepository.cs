using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.DataTransfer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbContext? DbContext;
        public GenericRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }
        public DbSet<TEntity> DbSet;
        public  Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
             DbSet.AddAsync(entity, cancellationToken);
             return Task.CompletedTask;
        }

        public Task AddAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            return DbSet.AddRangeAsync(entities , cancellationToken);
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
