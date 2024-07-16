using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using AutoMapper;
using Domain.Events.Request.Events;
using MediatR;

namespace Application.Events.Request.Handlers.CreatePruductEventsGroup
{
    public class UpdateItemQuantityStockNotificationEventHandle : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IMediator _mediator;

        public UpdateItemQuantityStockNotificationEventHandle(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            var itemUpdateCommand = new ItemUpdateCommand(notification.RequestItensEntities);

            await _mediator.Send(itemUpdateCommand, cancellationToken);
        }
    }
}
