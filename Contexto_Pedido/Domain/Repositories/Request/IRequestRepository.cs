using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories.Request.Interfaces;

namespace Domain.Repositories.Request
{
    public interface IRequestRepository : IRequestCreate, IRequestUpdate, IRequestDelete, IRequestRead
    {

    }
}
