using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Item;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Item.Queries;
using Validations.Request.SQLValidation.Item;

namespace Infrastructure.Request.Repositories.Item
{
    public class ItemRepository : IItemRepository
    {
        private readonly RequestDataContext _dataContext;

        public ItemRepository(RequestDataContext dataContext)
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
