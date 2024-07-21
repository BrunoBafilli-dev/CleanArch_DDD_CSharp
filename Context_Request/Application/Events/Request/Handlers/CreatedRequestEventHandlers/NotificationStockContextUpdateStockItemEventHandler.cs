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
using Domain.Shared_Kernel.Stock.Events.Event;
using Domain.Shared_Kernel.Stock.Events.IEventBus;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class NotificationStockContextUpdateStockItemEventHandler : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly SKIEventBus _skiEventBus;

        public NotificationStockContextUpdateStockItemEventHandler(SKIEventBus skiEventBus)
        {
            _skiEventBus = skiEventBus;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            var updatedItemsStockDomainEvent = UpdatedItemStockDomainEventMapFactory(notification.RequestItensEntities);

            SKUpdatedStockDomainEvent updatedStockDomainEvent =
                new SKUpdatedStockDomainEvent(notification.Id, updatedItemsStockDomainEvent);

            await _skiEventBus.Publish(updatedStockDomainEvent);
        }

        private List<SKItemStockUpdate> UpdatedItemStockDomainEventMapFactory(List<RequestItemEntity> itensEntities)
        {
            List<SKItemStockUpdate> updatedItemStockDomainEventMap =
                new List<SKItemStockUpdate>();

            foreach (var requestItemEntity in itensEntities)
                updatedItemStockDomainEventMap.Add(new SKItemStockUpdate(requestItemEntity.ItemId, requestItemEntity.QuantityItem.Quantity));

            return updatedItemStockDomainEventMap;
        }
    }
}
