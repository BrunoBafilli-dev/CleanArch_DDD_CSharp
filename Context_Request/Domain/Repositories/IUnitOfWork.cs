using Domain.Request.Repositories.Item;
using Domain.Request.Repositories.Request;

namespace Domain.Request.Repositories
{
    public interface IUnitOfWork
    {
        public IRequestRepository RequestRepository { get; }
        public IItemRepository ItemRepository { get; }

        Task CommitAsync();
    }
}