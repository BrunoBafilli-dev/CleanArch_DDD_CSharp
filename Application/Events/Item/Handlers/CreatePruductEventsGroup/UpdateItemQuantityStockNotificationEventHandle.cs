using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using Domain.Events.Events;
using MediatR;

namespace Application.Events.Request.Handlers.CreatePruductEventsGroup
{
    public class UpdateItemQuantityStockNotificationEventHandle : INotificationHandler<UpdatedStockDomainEvent>
    {
        private readonly IMediator _mediator;

        public UpdateItemQuantityStockNotificationEventHandle(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(UpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        {
            var itemUpdateCommand = new ItemStockReduceUpdateCommand(notification.Id, notification.RemoveQuantity, notification.OcurredOn);

            await _mediator.Send(itemUpdateCommand, cancellationToken);
        }
    }
}
