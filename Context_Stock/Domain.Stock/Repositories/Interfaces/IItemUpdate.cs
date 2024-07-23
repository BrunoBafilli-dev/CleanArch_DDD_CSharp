using Domain.Stock.Entities.Item;

namespace Domain.Stock.Repositories.Interfaces
{
    public interface IItemUpdate
    {
        Task UpdateItemsStockAsync(int itemId, int quantityItem);
    }
}
