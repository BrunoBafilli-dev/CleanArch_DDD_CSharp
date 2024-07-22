using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Entities.Item;
using Domain.Stock.Repositories.Item;
using Infrastructure.Stock.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Validations.Request.DomainValidation.Item;
using Validations.Request.SQLValidation.Item;

namespace Infrastructure.Stock.Repository.Item
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDataContext _itemDataContext;

        public ItemRepository(ItemDataContext itemDataContext)
        {
            _itemDataContext = itemDataContext;
        }

        public Task CreateItemAsync(ItemEntity itemEntity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(ItemEntity itemEntity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateItemsStockAsync(int itemId, int quantityItem)
        {
            var foundItem = await _itemDataContext.ItemEntities.FindAsync(itemId);

            ItemValidationSQLException.ItemValidationNotFoundSQLException(foundItem, nameof(foundItem));

            foundItem.StockReduceQuantity(quantityItem);
        }

        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemEntity> ReadItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
