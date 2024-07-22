using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Repositories;
using Domain.Stock.Repositories.Item;

namespace Infrastructure.Stock.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IItemRepository ItemRepository { get; }


        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
