using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.EventBus;
using Domain.Request.Entities.Request;
using Domain.Request.Events.Request.Events;
using Domain.Request.UnitOfWork;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CompensationRequestEventHandlers
{
    public class CompensationRequestDeletedEventHandler : INotificationHandler<CompensationRequestDeleteDomainEvent>
    {
        private readonly IEventBus _eventBus;

        public CompensationRequestDeletedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task Handle(CompensationRequestDeleteDomainEvent notification, CancellationToken cancellationToken)
        {
            await _eventBus.Send(new RequestRemoveCommand(notification.RequestId));
        }
    }
}
