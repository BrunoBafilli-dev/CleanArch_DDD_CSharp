using Domain.Entities.Item;

namespace Domain.Repositories.Item.Interfaces
{
    public interface IItemUpdate
    {
        Task UpdateItemAsync(ItemEntity itemEntity);
        Task UpdateItemsStockAsync(List<ItemEntity> itensEntities);
    }
}
