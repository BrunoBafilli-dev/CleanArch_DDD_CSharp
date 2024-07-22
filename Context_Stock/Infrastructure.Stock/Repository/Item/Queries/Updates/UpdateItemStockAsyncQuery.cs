using Infrastructure.Stock.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations.Request.SQLValidation.Item;

namespace Infrastructure.Stock.Repository.Item.Queries.Updates
{
    public class UpdateItemStockAsyncQuery
    {
        public static async Task UpdateItemsStockAsync(int itemId, int quantityItem, ItemDataContext _itemDataContext)
        {
            var foundItem = await _itemDataContext.ItemEntities.FindAsync(itemId);

            ItemValidationSQLException.ItemValidationNotFoundSQLException(foundItem, nameof(foundItem));

            foundItem.StockReduceQuantity(quantityItem);
        }
    }
}
