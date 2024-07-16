using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Domain.Repositories.Item;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Item.Queries;
using Microsoft.EntityFrameworkCore;
using Validations.SQLValidation.Item;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task UpdateItemsStockAsync(List<RequestItemEntity> requestItemsEntities)
        {
            await StockQuantityReduceQuery.UpdateStock(requestItemsEntities, _dataContext);
        }


        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RequestEntity> ReadItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
