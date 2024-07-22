using Domain.Request.Events.Request.Interfaces;
using MediatR;

namespace Application.Request.Events.Request.Events
{
    public class CompensationRequestCreatedEvent : INotification, IDomainEvent
    {
        public int RequestId { get; set; }
        public DateTime OcurredOn { get; set; }

        public CompensationRequestCreatedEvent(int requestId)
        {
            RequestId = requestId;
        }
    }
}
