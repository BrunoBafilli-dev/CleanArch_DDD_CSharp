using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Item;
using Domain.Repositories.Request;
using Domain.UnitOfWork;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Item;
using Infrastructure.Repositories.Request;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable, IAsyncDisposable
    {
        // Dependencies
        private readonly DataContext _dataContext;

        // Private properties
        private IRequestRepository _requestRepository;
        private IItemRepository _itemRepository;

        // Public properties
        public IRequestRepository RequestRepository => _requestRepository ??= new RequestRepository(_dataContext);
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
    }
}
