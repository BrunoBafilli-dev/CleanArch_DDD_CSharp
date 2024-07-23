using Application.Request.Events.Request.Events;
using Domain.Request.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.Events.EventBus;

namespace Application.Request.Events.Request.Saga
{
    public class UpdateReduceStockSaga : IUpdateReduceStockSaga
    {
        private readonly IEventBus _eventBus;

        public UpdateReduceStockSaga(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task UpdateStockOrCompensate(RequestEntity requestEntity)
        {
            try
            {
                await RequestCreatedDispatchEvents(requestEntity);
            }
            catch (Exception e)
            {
                await CompensationEventDispatchEvent(requestEntity);
                throw;
            }
        }

        public async Task RequestCreatedDispatchEvents(RequestEntity requestEntity)
        {
            foreach (var @event in requestEntity.RequestCreatedDomainEvents)
            {
                await _eventBus.Publish(@event);
            }
        }

        public async Task CompensationEventDispatchEvent(RequestEntity requestEntity)
        {
            await _eventBus.Publish(new CompensationRequestRemovedEvent(requestEntity.Id));
        }
    }
}
