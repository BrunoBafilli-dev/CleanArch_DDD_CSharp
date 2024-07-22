using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.EventBus;
using Domain.Request.Events.Request.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CompensationRequestDeletedEventHandlers
{
    public class CompensationRequestRemovedEventHandler : INotificationHandler<CompensationRequestDeleteDomainEvent>
    {
        private readonly IEventBus _eventBus;

        public CompensationRequestRemovedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task Handle(CompensationRequestDeleteDomainEvent notification, CancellationToken cancellationToken)
        {
            await _eventBus.Send(new RequestRemoveCommand(notification.RequestId));
        }
    }
}
