using Domain.Request.Events.Request.Interfaces;

namespace Application.Request.Events.EventBus
{
    public interface IEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IDomainEvent;
    }
}
