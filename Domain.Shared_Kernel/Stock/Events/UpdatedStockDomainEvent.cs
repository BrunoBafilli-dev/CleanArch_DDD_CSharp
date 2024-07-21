using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Shared_Kernel.Stock.Interfaces;

namespace Domain.Shared_Kernel.Stock.Events
{
    public class UpdatedStockDomainEvent : IDomainEvent, INotification
    {
        public int RequestId { get; private set; }
        public List<UpdatedItemStockDomainEventMap> UpdatedItemsStockDomainEventMap { get; private set; }
        public DateTime OcurredOn { get; private set; }

        public UpdatedStockDomainEvent(int requestId, List<UpdatedItemStockDomainEventMap> updatedItemsStockDomainEventMap)
        {
            RequestId = requestId;
            UpdatedItemsStockDomainEventMap = updatedItemsStockDomainEventMap;
            OcurredOn = DateTime.Now;
        }
    }

    public class UpdatedItemStockDomainEventMap
    {
        public int ItemId { get; set; }
        public int QuantityItem { get; set; }

        public UpdatedItemStockDomainEventMap(int itemId, int quantityItem)
        {
            ItemId = itemId;
            QuantityItem = quantityItem;
        }
    }
}
