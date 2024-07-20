using Domain.Request.Events.Request.Interfaces;
using MediatR;

namespace Application.Request.Events.EventBus
{
    public class EventBus : IEventBus
    {
        private readonly IMediator _mediator;

        public EventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Publish<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            await _mediator.Publish(@event);
        }
    }
}
