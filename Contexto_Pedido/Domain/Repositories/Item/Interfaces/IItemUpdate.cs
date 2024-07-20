using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;

namespace Domain.Request.Repositories.Item.Interfaces
{
    public interface IItemUpdate
    {
        Task UpdateItemAsync(ItemEntity itemEntity);
        Task UpdateItemsStockAsync(List<RequestItemEntity> requestItemsEntities);
    }
}
