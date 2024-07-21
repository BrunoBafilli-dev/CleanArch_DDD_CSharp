using Domain.Request.Events.Request.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.Events.EventBus;
using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;
using Domain.Shared_Kernel.Stock.Events;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class NotificationStockContextUpdateStockItemEventHandle : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly IMediator _mediator;

        public NotificationStockContextUpdateStockItemEventHandle(IEventBus eventBus, IMediator mediator)
        {
            _eventBus = eventBus;
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            var updatedItemsStockDomainEvent = Factory(notification.RequestItensEntities);

            UpdatedStockDomainEvent updatedStockDomainEvent =
                new UpdatedStockDomainEvent(notification.Id, updatedItemsStockDomainEvent);

            await _mediator.Publish(updatedStockDomainEvent);
        }

        public List<UpdatedItemStockDomainEventMap> Factory(List<RequestItemEntity> itensEntities)
        {
            List<UpdatedItemStockDomainEventMap> updatedItemStockDomainEventMap =
                new List<UpdatedItemStockDomainEventMap>();

            foreach (var requestItemEntity in itensEntities)
                updatedItemStockDomainEventMap.Add(new UpdatedItemStockDomainEventMap(requestItemEntity.ItemId, requestItemEntity.QuantityItem.Quantity));

            return updatedItemStockDomainEventMap;
        }
    }
}
