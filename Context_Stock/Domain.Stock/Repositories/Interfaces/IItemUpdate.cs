using Domain.Stock.Entities.Item;

namespace Domain.Stock.Repositories.Interfaces
{
    public interface IItemUpdate
    {
        Task UpdateItemAsync(ItemEntity itemEntity);
    }
}
