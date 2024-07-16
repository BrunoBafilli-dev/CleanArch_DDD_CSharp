using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Request.Interfaces
{
    public interface IRequestDelete
    {
        Task DeleteRequestAsync(int id);
    }
}
