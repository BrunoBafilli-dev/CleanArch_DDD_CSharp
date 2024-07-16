using Domain.Repositories.Request.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Item.Interfaces;

namespace Domain.Repositories.Item
{
    public interface IItemRepository : IItemCreate, IItemUpdate, IItemDelete, IItemRead
    {
    }
}
