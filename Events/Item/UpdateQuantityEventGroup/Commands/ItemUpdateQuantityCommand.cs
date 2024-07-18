using Domain.Entities.Item;
using Domain.Events.Events;
using MediatR;

namespace SharedKernel.Events.Item.UpdateQuantityEventGroup.Commands
{
    public class ItemUpdateQuantityCommand : IRequest<ItemEntity>
    {
        public List<dynamic> UpdatedStockDomainEvent { get; private set; }
        public DateTime OcurredOn { get; }

        public ItemUpdateQuantityCommand(List<dynamic> updatedStockDomainEvents)
        {
            OcurredOn = DateTime.Now;
            UpdatedStockDomainEvent = updatedStockDomainEvents;
        }
    }
}
