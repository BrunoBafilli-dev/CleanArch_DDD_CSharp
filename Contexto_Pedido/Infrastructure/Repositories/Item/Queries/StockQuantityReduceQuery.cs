using Domain.Entities.Request;
using Infrastructure.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Microsoft.EntityFrameworkCore;
using Validations.SQLValidation.Item;

namespace Infrastructure.Repositories.Item.Queries
{
    public class StockQuantityReduceQuery
    {
        public static async Task UpdateStock(List<RequestItemEntity> requestItemsEntities, DataContext dataContext)
        {
            var itemIds = requestItemsEntities.Select(item => item.ItemId).ToList();

            ValidateItemsExist(itemIds, dataContext);

            var itemsDictionary = await FetchItems(itemIds, dataContext);

            await ApplyStockChanges(requestItemsEntities, itemsDictionary, dataContext);
        }

        private static void ValidateItemsExist(List<int> itemIds, DataContext dataContext)
        {
            // Validação fictícia, adicione a implementação real aqui
            if (!dataContext.ItemEntities.Any(item => itemIds.Contains(item.Id)))
            {
                throw new ItemValidationSQLException("Alguns itens não foram encontrados.");
            }
        }

        private static async Task<Dictionary<int, ItemEntity>> FetchItems(List<int> itemIds, DataContext dataContext)
        {
            return await dataContext.ItemEntities
                .Where(item => itemIds.Contains(item.Id))
                .ToDictionaryAsync(item => item.Id);
        }

        private static async Task ApplyStockChanges(List<RequestItemEntity> requestItemsEntities, Dictionary<int, ItemEntity> itemsDictionary, DataContext dataContext)
        {
            foreach (var requestItem in requestItemsEntities)
            {
                if (itemsDictionary.TryGetValue(requestItem.ItemId, out var item))
                {
                    item.StockReduceQuantity(requestItem.QuantityItem.Quantity);
                }
            }
            await dataContext.SaveChangesAsync();
        }
    }

}
