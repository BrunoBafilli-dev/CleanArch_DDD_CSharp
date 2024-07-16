using Domain.Entities.Item;
using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Item.Interfaces
{
    public interface IItemUpdate
    {
        Task UpdateItemAsync(ItemEntity itemEntity);
        Task UpdateItemsStockAsync(List<RequestItemEntity> requestItemsEntities);
    }
}
