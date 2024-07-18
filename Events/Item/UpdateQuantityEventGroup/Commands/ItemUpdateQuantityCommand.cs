using Domain.Entities.Item;
using Domain.Events.Events;
using MediatR;

namespace SharedKernel.Events.Item.UpdateQuantityEventGroup.Commands
{
    public class ItemUpdateQuantityCommand : IRequest<ItemEntity>
    {
        //public List<UpdatedStockDomainEvent> UpdatedStockDomainEvent { get; private set; } = new List<UpdatedStockDomainEvent>();
        public DateTime OcurredOn { get; }

        public ItemUpdateQuantityCommand(List<dynamic> updatedStockDomainEvents)
        {
            OcurredOn = DateTime.Now;

            foreach (dynamic itemEntityEvent in updatedStockDomainEvents)
            {
                // Utilizando um método estático de fábrica para criar instâncias de UpdatedStockDomainEvent
                //UpdatedStockDomainEvent.Add(CreateFromDynamicFactory(itemEntityEvent));
            }
        }

        // Método de fábrica para criar instâncias a partir de um objeto dinâmico
        public static UpdatedStockDomainEvent CreateFromDynamicFactory(dynamic item)
        {
            return new UpdatedStockDomainEvent((int)item.ItemId, (int)item.RemoveQuantity, (DateTime)item.OcurredOn);
        }
    }
}
