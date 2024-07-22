using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Repositories.Item;

namespace Domain.Stock.Repositories
{
    public interface IUnitOfWork
    {
        public IItemRepository ItemRepository { get; }

        public Task CommitAsync();
    }
}
