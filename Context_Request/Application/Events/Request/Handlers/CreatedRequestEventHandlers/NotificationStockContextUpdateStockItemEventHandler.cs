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
    public class NotificationStockContextUpdateStockItemEventHandler : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IMediator _mediator;

        public NotificationStockContextUpdateStockItemEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            var updatedItemsStockDomainEvent = UpdatedItemStockDomainEventMapFactory(notification.RequestItensEntities);

            SKUpdatedStockDomainEvent updatedStockDomainEvent =
                new SKUpdatedStockDomainEvent(notification.Id, updatedItemsStockDomainEvent);

            await _mediator.Publish(updatedStockDomainEvent);
        }

        private List<SKUpdatedItemStockDomainEventMap> UpdatedItemStockDomainEventMapFactory(List<RequestItemEntity> itensEntities)
        {
            List<SKUpdatedItemStockDomainEventMap> updatedItemStockDomainEventMap =
                new List<SKUpdatedItemStockDomainEventMap>();

            foreach (var requestItemEntity in itensEntities)
                updatedItemStockDomainEventMap.Add(new SKUpdatedItemStockDomainEventMap(requestItemEntity.ItemId, requestItemEntity.QuantityItem.Quantity));

            return updatedItemStockDomainEventMap;
        }
    }
}
