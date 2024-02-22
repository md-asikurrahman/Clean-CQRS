using CleanArchitecture.DataTransfer.Repository;

namespace CleanArchitecture.DataTransfer.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        void SaveChanges();
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
        IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class;

    }
}
