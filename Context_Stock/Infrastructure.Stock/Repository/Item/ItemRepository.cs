using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Entities.Item;
using Domain.Stock.Repositories.Item;

namespace Infrastructure.Stock.Repository.Item
{
    public class ItemRepository : IItemRepository
    {
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
            throw new NotImplementedException();
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
