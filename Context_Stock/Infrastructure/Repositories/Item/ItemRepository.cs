using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Item;
using Domain.Repositories.Item;
using Domain.Repositories.Item.Interfaces;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Item.Queries;
using Microsoft.EntityFrameworkCore;
using Validations.SQLValidation.Item;

namespace Infrastructure.Repositories.Item
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _dataContext;

        public ItemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task CreateItemAsync(ItemEntity itemEntity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateItemAsync(ItemEntity itemEntity)
        {
            var findedItem = await _dataContext.ItemEntities.FindAsync(itemEntity.Id);

            ItemValidationSQLException.ItemValidationNotFoundSQLException(findedItem, nameof(findedItem));

            _dataContext.Entry(findedItem).CurrentValues.SetValues(itemEntity);
        }

        public async Task UpdateItemsStockAsync(int removeQuantity, int itemId)
        {
            //await StockQuantityReduceQuery.UpdateStock(removeQuantity, itemId, _dataContext);
        }

        public Task UpdateItemsStockAsync(int quantity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ItemEntity> IItemRead.ReadItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
