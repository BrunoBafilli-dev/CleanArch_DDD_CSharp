using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Repositories;
using Domain.Stock.Repositories.Item;
using Infrastructure.Stock.Database.EntityFramework;
using Infrastructure.Stock.Repository.Item;

namespace Infrastructure.Stock.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable, IAsyncDisposable
    {
        // Dependencies
        private readonly ItemDataContext _itemDataContext;

        // Private properties
        private IItemRepository _itemRepository;

        // Public properties
        public IItemRepository ItemRepository => _itemRepository ??= new ItemRepository(_itemDataContext);

        // Constructor
        public UnitOfWork(ItemDataContext itemDataContext)
        {
            _itemDataContext = itemDataContext;
        }

        // Methods
        public async Task CommitAsync()
        {
            await _itemDataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _itemDataContext.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _itemDataContext.DisposeAsync();
        }
    }
}
