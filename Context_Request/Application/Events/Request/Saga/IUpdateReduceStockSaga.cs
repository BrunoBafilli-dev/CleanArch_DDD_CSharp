using Domain.Request.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Events.Request.Saga
{
    public interface IUpdateReduceStockSaga
    {
        Task UpdateStockOrCompensate(RequestEntity requestEntity);
        Task RequestCreatedDispatchEvents(RequestEntity requestEntity);
        Task CompensationEventDispatchEvent(RequestEntity requestEntity);
    }
}
