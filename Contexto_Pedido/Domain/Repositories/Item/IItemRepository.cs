using Domain.Request.Repositories.Item.Interfaces;

namespace Domain.Request.Repositories.Item
{
    public interface IItemRepository : IItemCreate, IItemUpdate, IItemDelete, IItemRead
    {
    }
}
