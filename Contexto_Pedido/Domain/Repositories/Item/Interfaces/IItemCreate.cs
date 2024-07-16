using Domain.Entities.Item;

namespace Domain.Repositories.Item.Interfaces
{
    public interface IItemCreate
    {
        Task CreateItemAsync(ItemEntity itemEntity);
    }
}
