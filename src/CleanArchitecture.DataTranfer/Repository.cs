using CleanArchitecture.DataTranfer.Contract;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.DataTranfer
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    where TEntity : class, IEntity<TKey> where TKey : IComparable<TKey>
        
    {
        private DbContext dbContext;
        public Repository(DbContext context)
        {
            dbContext = context;
            DbSet = dbContext.Set<TEntity>();
        }
        public DbSet<TEntity> DbSet { get; set; }

        public Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
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

        public Task<TEntity> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
