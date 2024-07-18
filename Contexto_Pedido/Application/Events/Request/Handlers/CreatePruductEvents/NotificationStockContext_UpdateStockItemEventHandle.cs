using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using Application.CQRS.Item.Handlers.Command;
using Application.Events.EventBus;
using Domain.Entities.Request;
using Domain.Events.Request.Events;
using Domain.UnitOfWork;
using MediatR;
using SharedKernel.Events.Item;
using SharedKernel.Events.Item.UpdateQuantityEventGroup.Commands;

namespace Application.Events.Request.Handlers.CreatePruductEventsGroup
{
    public class NotificationStockContext_UpdateStockItemEventHandle : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IMediator _mediator;

        public NotificationStockContext_UpdateStockItemEventHandle(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            List<object> itemsEntities = new List<object>();

            foreach (var itemEntity in notification.RequestItensEntities)
            {
                itemsEntities.Add(itemEntity);
            }

            //await _mediator.Send(new ItemUpdateQuantityCommand(itemsEntities));
        }
    }
}
