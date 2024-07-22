using Domain.Request.Repositories;
using Domain.Request.Repositories.Item;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Item;
using Infrastructure.Request.Repositories.Request;

namespace Infrastructure.Request.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable, IAsyncDisposable
    {
        // Dependencies
        private readonly RequestDataContext _dataContext;

        // Private properties
        private IRequestRepository _requestRepository;
        private IItemRepository _itemRepository;

        // Public properties
        public IRequestRepository RequestRepository => _requestRepository ??= new RequestRepository(_dataContext);
        public IItemRepository ItemRepository => _itemRepository ??= new ItemRepository(_dataContext);

        // Constructor
        public UnitOfWork(RequestDataContext dataContext)
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
    }
}
