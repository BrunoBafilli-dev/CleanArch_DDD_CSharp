using Domain.Stock.Entities.Item;

namespace Domain.Stock.Repositories.Interfaces
{
    public interface IItemCreate
    {
        Task CreateItemAsync(ItemEntity itemEntity);
    }
}
