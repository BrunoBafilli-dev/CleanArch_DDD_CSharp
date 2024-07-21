using Domain.SharedKernel.Stock.Events.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SharedKernel.Stock.Events.EventBus
{
    public interface SKIEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : ISKIDomainEvent;
    }
}
