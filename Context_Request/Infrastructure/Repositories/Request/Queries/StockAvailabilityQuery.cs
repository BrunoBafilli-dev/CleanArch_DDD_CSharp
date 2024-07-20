using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Request.Repositories.Request.Queries
{
    public class StockAvailabilityQuery
    {
        public static async Task StockAvailabilityAndAdjustment(RequestEntity requestEntity, DataContext _dataContext)
        {
            var items = await LoadItems(requestEntity, _dataContext);

            ValidateItems(requestEntity, items);
        }

        private static async Task<Dictionary<int, ItemEntity>> LoadItems(RequestEntity requestEntity, DataContext dataContext)
        {
            var itemIds = requestEntity.RequestItensEntities.Select(ie => ie.ItemId).ToList();

            return await dataContext.ItemEntities
                                    .Where(ie => itemIds.Contains(ie.Id))
                                    .ToDictionaryAsync(ie => ie.Id, ie => ie);
        }

        private static void ValidateItems(RequestEntity requestEntity, Dictionary<int, ItemEntity> items)
        {
            foreach (var itemEntity in requestEntity.RequestItensEntities)
            {
                if (!items.ContainsKey(itemEntity.ItemId))
                {
                    throw new ArgumentException("Item não encontrado: " + itemEntity.Id);
                }

                var item = items[itemEntity.ItemId];

                if (item.QuantityItemStock.Quantity < itemEntity.QuantityItem.Quantity)
                {
                    throw new ArgumentException("Estoque insuficiente para o item: " + item.Name);
                }

                if (item.Name != itemEntity.Name)
                {
                    throw new ArgumentException("Nome do item incorreto para o item ID " + itemEntity.Id);
                }

                if (item.PriceItem.Price != itemEntity.PriceItem.Price)
                {
                    throw new ArgumentException("Preço incorreto para o item ID " + itemEntity.Id);
                }
            }
        }
    }
}
