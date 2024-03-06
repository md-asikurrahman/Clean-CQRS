using CleanArchitecture.DataTransfer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CleanArchitecture.DataTransfer.UnitOfWorks
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        private bool disposedValue;
        private TContext? DbContext { get; set; }
        private readonly Dictionary<Type, object> _repositories = new();
        private IDbContextTransaction _transaction = null!;

        public UnitOfWork(TContext context)
        {
           DbContext = context;
        }
        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            _transaction = await DbContext!.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _transaction.CommitAsync(cancellationToken);
            }
            catch (Exception)
            {

                await _transaction.RollbackAsync(cancellationToken); ;
            }
            finally
            {
                await _transaction.DisposeAsync();
                _transaction = null!;
            }
        }

        public async ValueTask DisposeAsync()
        {
            Dispose(disposing: false);
            await DisposeAsyncCore().ConfigureAwait(false);
            GC.SuppressFinalize(this);
        }
        private async ValueTask DisposeAsyncCore()
        {
            if (DbContext is not null)
            {
                await DbContext.DisposeAsync().ConfigureAwait(false);
            }

            DbContext = null;
        }

        public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);
            if (_repositories.ContainsKey(type))
            {
                return (_repositories[type] as IGenericRepository<TEntity>)!;
            }

            var repository = new GenericRepository<TEntity>(DbContext!);
            _repositories.Add(type, repository);
        }
        //public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class
        //{
        //    var type = typeof(TEntity);
        //    if (_repositories.ContainsKey(type))
        //    {
        //        return (_repositories[type] as IGenericRepository<TEntity>)!;
        //    }

        //    //var repository = new GenericRepository<TEntity>(DbContext!);
        //    //_repositories.Add(type, repository);
        //}

        public Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext!.SaveChangesAsync(cancellationToken);
        }

        public void SaveChanges()
        {
            DbContext!.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    DbContext!.Dispose();
                    DbContext = null;
                }

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

       
    }
}
