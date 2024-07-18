using Domain.Repositories;
using Domain.Repositories.Item;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Item;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable, IAsyncDisposable
    {
        // Dependencies
        private readonly DataContext _dataContext;

        // Private properties
        private IItemRepository _itemRepository;

        // Public properties
        public IItemRepository ItemRepository => _itemRepository ??= new ItemRepository(_dataContext);

        // Constructor
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Methods
        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _dataContext.DisposeAsync();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
