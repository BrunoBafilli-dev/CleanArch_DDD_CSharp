using Domain.Request.Entities.Request;
using Domain.Request.Events.Request.Events;
using Domain.SharedKernel.Stock.Events.EventBus;
using Domain.SharedKernel.Stock.Events.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CreatedRequestEventHandlers
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
