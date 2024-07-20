using Domain.Repositories.Item.Interfaces;

namespace Domain.Repositories.Item
{
    public interface IItemRepository : IItemCreate, IItemUpdate, IItemDelete, IItemRead
    {
    }
}
