using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Stock.Repository.Item.Queries.Interfaces
{
    public interface IItemRepositoryUpdateQueriesFaced
    {
        public Task UpdateItemStockQueryAsync(int itemId, int quantityItem);
    }
}
