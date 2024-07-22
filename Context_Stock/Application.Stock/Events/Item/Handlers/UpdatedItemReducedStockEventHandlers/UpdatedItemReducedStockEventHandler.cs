using Domain.SharedKernel.Stock.Events.Events;
using MediatR;

namespace Application.Stock.Events.Item.Handlers.UpdatedItemReducedStockEventHandlers
{
    public class UpdatedItemReducedStockEventHandler : INotificationHandler<SKUpdatedStockDomainEvent>
    {
        public Task Handle(SKUpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.OcurredOn + " - " + notification.RequestId);

            foreach (var updatedItemStockDomainEventMap in notification.SKItemStockUpdate)
            {
                Console.WriteLine($"itemID: {updatedItemStockDomainEventMap.ItemId} - Quantity: {updatedItemStockDomainEventMap.QuantityItem}");
            }

            return Task.CompletedTask;
        }
    }
}
