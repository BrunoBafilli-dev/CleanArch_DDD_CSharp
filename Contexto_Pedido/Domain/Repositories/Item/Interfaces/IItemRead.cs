using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Item.Interfaces
{
    public interface IItemRead
    {
        Task<RequestEntity> ReadItemByIdAsync(int id);
    }
}
