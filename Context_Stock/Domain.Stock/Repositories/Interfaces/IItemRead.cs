using Domain.Stock.Entities.Item;

namespace Domain.Stock.Repositories.Interfaces
{
    public interface IItemRead
    {
        Task<ItemEntity> ReadItemByIdAsync(int id);
    }
}
