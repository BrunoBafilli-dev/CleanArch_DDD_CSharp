using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Item;

namespace Domain.Repositories
{
    public interface IUnitOfWork
    {
        public IItemRepository ItemRepository { get; set; }

        Task CommitAsync();
    }
}
