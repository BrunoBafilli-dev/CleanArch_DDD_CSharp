using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Request;

namespace Domain.Repositories.Request.Interfaces
{
    public interface IRequestCreate
    {
        Task CreateRequestAsync(RequestEntity requestEntity);
    }
}
