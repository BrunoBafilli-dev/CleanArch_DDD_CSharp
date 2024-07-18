using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Domain.Events.Events;
using Domain.Events.Request.Interfaces;
using MediatR;

namespace Application.CQRS.Item.Commands
{
    public class ItemStockReduceUpdateCommand : IRequest<ItemEntity>, IDomainEvent
    {
        public List<UpdatedStockDomainEvent> UpdatedStockDomainEvent { get; private set; }
        public int Id { get; }
        public DateTime OcurredOn { get; }

        // Usando List<dynamic> se a estrutura dos objetos é conhecida e consistente
        public ItemStockReduceUpdateCommand(List<dynamic> itemsEntities)
        {
            UpdatedStockDomainEvent = new List<UpdatedStockDomainEvent>();
            OcurredOn = DateTime.Now;

            foreach (dynamic itemEntity in itemsEntities)
            {
                // Utilizando um método estático de fábrica para criar instâncias de ItemsEntities
                UpdatedStockDomainEvent.Add();//
            }
        }
    }

    //public class UpdatedStockDomainEventMap
    //{
    //    public int ItemId { get; private set; }
    //    public int RemoveQuantity { get; private set; }
    //    public DateTime OcurredOn { get; private set; }

    //    private ItemsEntities(int itemId, int removeQuantity, DateTime ocurredOn)
    //    {
    //        ItemId = itemId;
    //        RemoveQuantity = removeQuantity;
    //        OcurredOn = ocurredOn;
    //    }

    //    // Método de fábrica para criar instâncias a partir de um objeto dinâmico
    //    public static ItemsEntities CreateFromDynamic(dynamic item)
    //    {
    //        return new ItemsEntities((int)item.ItemId, (int)item.RemoveQuantity, (DateTime)item.OcurredOn);
    //    }
    //}
}
