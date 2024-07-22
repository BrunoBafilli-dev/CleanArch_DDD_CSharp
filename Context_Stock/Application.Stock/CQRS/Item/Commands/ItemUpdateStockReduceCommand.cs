using Domain.SharedKernel.Stock.Events.Events;
using Domain.Stock.Entities.Item;
using MediatR;

namespace Application.Stock.CQRS.Item.Commands
{
    public class ItemUpdateStockReduceCommand : IRequest<ItemEntity>
    {
        public SKUpdatedStockDomainEvent SKUpdatedStockDomainEvent { get; private set; }

        public ItemUpdateStockReduceCommand(SKUpdatedStockDomainEvent skUpdatedStockDomainEvent)
        {
            SKUpdatedStockDomainEvent = skUpdatedStockDomainEvent;
        }
    }
}
