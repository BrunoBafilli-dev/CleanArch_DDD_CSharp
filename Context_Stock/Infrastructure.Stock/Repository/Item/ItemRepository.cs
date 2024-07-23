using Domain.Stock.Entities.Item;
using Domain.Stock.Repositories.Item;
using Infrastructure.Stock.Database.EntityFramework;
using Infrastructure.Stock.Repository.Item.Queries;

namespace Infrastructure.Stock.Repository.Item
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDataContext _itemDataContext;
        private readonly ItemRepositoryUpdateQueriesFaced _itemRepositoryUpdateQueriesFaced;

        public ItemRepository(ItemDataContext itemDataContext)
        {
            _itemDataContext = itemDataContext;
            _itemRepositoryUpdateQueriesFaced = new ItemRepositoryUpdateQueriesFaced(_itemDataContext);;
        }

        public Task UpdateItemAsync(ItemEntity itemEntity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateItemsStockAsync(int itemId, int quantityItem)
        {
            await _itemRepositoryUpdateQueriesFaced.UpdateItemStockQueryAsync(itemId, quantityItem);
        }
    }
}
