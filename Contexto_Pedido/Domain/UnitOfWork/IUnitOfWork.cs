using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Item;
using Domain.Repositories.Item.Interfaces;
using Domain.Repositories.Request;

namespace Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRequestRepository RequestRepository { get; }
        public IItemRepository ItemRepository { get; }

        Task CommitAsync();
    }
}
