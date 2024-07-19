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
        public List<object> UpdatedStockDomainEvent { get; private set; }
        public DateTime OcurredOn { get; }
    }
}
