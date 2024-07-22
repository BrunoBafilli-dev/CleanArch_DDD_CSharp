using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SharedKernel.Stock.Events.Domain;
using MediatR;

namespace Domain.SharedKernel.Stock.Events.EventBus
{
    public class SKEventBus : SKIEventBus
    {
        private readonly IMediator _mediator;

        public SKEventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Publish<TEvent>(TEvent @event) where TEvent : ISKIDomainEvent
        {
            _mediator.Publish(@event);

            return Task.CompletedTask;
        }
    }
}
