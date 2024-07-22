using Domain.SharedKernel.Stock.Events.Domain;
using MediatR;

namespace Domain.SharedKernel.Stock.Events.Events
{
    public class SKUpdatedStockDomainEvent : ISKIDomainEvent, INotification
    {
        public int RequestId { get; private set; }
        public List<SKItemStockUpdate> SKItemStockUpdate { get; private set; }
        public DateTime OcurredOn { get; private set; }

        public SKUpdatedStockDomainEvent(int requestId, List<SKItemStockUpdate> skItemStockUpdate)
        {
            RequestId = requestId;
            SKItemStockUpdate = skItemStockUpdate;
            OcurredOn = DateTime.Now;
        }
    }

    public class SKItemStockUpdate
    {
        public int ItemId { get; set; }
        public int QuantityItem { get; set; }

        public SKItemStockUpdate(int itemId, int quantityItem)
        {
            ItemId = itemId;
            QuantityItem = quantityItem;
        }
    }
}