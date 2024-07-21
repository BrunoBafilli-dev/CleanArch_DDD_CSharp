using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Shared_Kernel.Stock.Interfaces;

namespace Domain.Shared_Kernel.Stock.Events
{
    public class SKUpdatedStockDomainEvent : SKIDomainEvent, INotification
    {
        public int RequestId { get; private set; }
        public List<SKUpdatedItemStockDomainEventMap> UpdatedItemsStockDomainEventMap { get; private set; }
        public DateTime OcurredOn { get; private set; }

        public SKUpdatedStockDomainEvent(int requestId, List<SKUpdatedItemStockDomainEventMap> updatedItemsStockDomainEventMap)
        {
            RequestId = requestId;
            UpdatedItemsStockDomainEventMap = updatedItemsStockDomainEventMap;
            OcurredOn = DateTime.Now;
        }
    }

    public class SKUpdatedItemStockDomainEventMap
    {
        public int ItemId { get; set; }
        public int QuantityItem { get; set; }

        public SKUpdatedItemStockDomainEventMap(int itemId, int quantityItem)
        {
            ItemId = itemId;
            QuantityItem = quantityItem;
        }
    }
}
