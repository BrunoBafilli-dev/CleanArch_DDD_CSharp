using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SharedKernel.Stock.Events.Events;
using MediatR;

namespace Domain.Stock
{
    public class Receiver : INotificationHandler<SKUpdatedStockDomainEvent>
    {
        public Task Handle(SKUpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.OcurredOn + " - " + notification.RequestId);

            foreach (var updatedItemStockDomainEventMap in notification.UpdatedItemsStockDomainEventMap)
            {
                Console.WriteLine($"itemID: {updatedItemStockDomainEventMap.ItemId} - Quantity: {updatedItemStockDomainEventMap.QuantityItem}");
            }

            return Task.CompletedTask;
        }
    }
}
