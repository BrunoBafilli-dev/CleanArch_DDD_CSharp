using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Request.Interfaces
{
    public interface IRequestUpdate
    {
        Task UpdateRequestAsync(RequestEntity requestEntity);
    }
}
