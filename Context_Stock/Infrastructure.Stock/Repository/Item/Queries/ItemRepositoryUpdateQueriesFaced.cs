using Infrastructure.Stock.Database.EntityFramework;
using Infrastructure.Stock.Repository.Item.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Stock.Repository.Item.Queries.Updates;

namespace Infrastructure.Stock.Repository.Item.Queries
{
    public class ItemRepositoryUpdateQueriesFaced : IItemRepositoryUpdateQueriesFaced
    {
        private readonly ItemDataContext _itemDataContext;

        public ItemRepositoryUpdateQueriesFaced(ItemDataContext itemDataContext)
        {
            _itemDataContext = itemDataContext;
        }

        public async Task UpdateItemStockQueryAsync(int itemId, int quantityItem)
        {
            await UpdateItemStockAsyncQuery.UpdateItemsStockAsync(itemId, quantityItem, _itemDataContext);
        }
    }
}
