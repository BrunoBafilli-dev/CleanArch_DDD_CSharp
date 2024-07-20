using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Request.Interfaces;

namespace Application.Events.EventBus
{
    public interface IEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IDomainEvent;
    }
}
