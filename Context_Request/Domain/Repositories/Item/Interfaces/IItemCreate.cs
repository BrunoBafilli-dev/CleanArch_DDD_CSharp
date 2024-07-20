using Domain.Request.Entities.Item;

namespace Domain.Request.Repositories.Item.Interfaces
{
    public interface IItemCreate
    {
        Task CreateItemAsync(ItemEntity itemEntity);
    }
}
