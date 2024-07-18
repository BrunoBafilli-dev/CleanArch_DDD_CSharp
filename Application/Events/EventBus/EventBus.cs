using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Request.Interfaces;
using MediatR;

namespace Application.Events.EventBus
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
