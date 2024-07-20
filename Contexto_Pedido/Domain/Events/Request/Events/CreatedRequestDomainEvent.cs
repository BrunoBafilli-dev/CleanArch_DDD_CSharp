using Domain.Request.Entities.Request;
using Domain.Request.Events.Request.Interfaces;
using MediatR;

namespace Domain.Request.Events.Request.Events
{
    public class CreatedRequestDomainEvent : IDomainEvent, INotification
    {
        public int Id { get; set; }
        public DateTime OcurredOn { get; set; }
        public List<RequestItemEntity> RequestItensEntities { get; set; }

        public CreatedRequestDomainEvent(int id, List<RequestItemEntity> requestItensEntities)
        {
            Id = id;
            RequestItensEntities = requestItensEntities;
            OcurredOn = DateTime.Now;
        }
    }
}
