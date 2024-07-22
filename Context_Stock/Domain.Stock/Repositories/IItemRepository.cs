using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Repositories.Interfaces;

namespace Domain.Stock.Repositories
{
    public interface IItemRepository : IItemCreate, IItemUpdate, IItemDelete, IItemRead
    {
    }
}