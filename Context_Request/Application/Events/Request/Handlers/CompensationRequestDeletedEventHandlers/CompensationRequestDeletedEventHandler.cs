using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.EventBus;
using Domain.Request.Events.Request.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CompensationRequestDeletedEventHandlers
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
