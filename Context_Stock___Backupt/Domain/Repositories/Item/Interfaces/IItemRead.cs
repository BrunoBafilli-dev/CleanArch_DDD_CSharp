using Domain.Entities.Item;

namespace Domain.Repositories.Item.Interfaces
{
    public interface IItemRead
    {
        Task<ItemEntity> ReadItemByIdAsync(int id);
    }
}
