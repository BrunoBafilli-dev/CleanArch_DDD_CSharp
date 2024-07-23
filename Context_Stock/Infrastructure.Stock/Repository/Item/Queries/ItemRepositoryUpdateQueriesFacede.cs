using Infrastructure.Stock.Database.EntityFramework;
using Infrastructure.Stock.Repository.Item.Queries.Updates;


namespace Infrastructure.Stock.Repository.Item.Queries
{
    public class ItemRepositoryUpdateQueriesFacede
    {
        private readonly ItemDataContext _itemDataContext;

        public ItemRepositoryUpdateQueriesFacede(ItemDataContext itemDataContext)
        {
            _itemDataContext = itemDataContext;
        }

        public async Task UpdateItemStockQueryAsync(int itemId, int quantityItem)
            => await UpdateItemStockAsyncQuery.UpdateItemsStockAsync(itemId, quantityItem, _itemDataContext);
    }
}
