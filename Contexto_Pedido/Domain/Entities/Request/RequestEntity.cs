using Domain.Request.Entities.Interfaces;
using Domain.Request.Events.Request.Events;
using Domain.Request.Events.Request.Interfaces;
using Validations;
using Validations.Request;

namespace Domain.Request.Entities.Request
{
    public class RequestEntity : Entity<int>, IAgregateRoot
    {
        private List<IDomainEvent> _requestCreatedDomainEvents = new List<IDomainEvent>();
        private List<RequestItemEntity> _requestItensEntities = new List<RequestItemEntity>();

        public IReadOnlyCollection<IDomainEvent> RequestCreatedDomainEvents => _requestCreatedDomainEvents;
        public IReadOnlyCollection<RequestItemEntity> RequestItensEntities => _requestItensEntities;

        public int ClientId { get; private set; }

        // Ctor
        public RequestEntity() { }//EF

        public RequestEntity(int clientId, ICollection<RequestItemEntity> requestItensEntities)
        {
            Validations(clientId);
            ClientId = clientId;
            CreateRequest(requestItensEntities);
        }

        // Methods
        public void CreateRequest(ICollection<RequestItemEntity> requestItensEntity)
        {
            _requestItensEntities.AddRange(requestItensEntity);
            RequestCreatedDomainEventsRegister();
        }

        private void RequestCreatedDomainEventsRegister()
        {
            _requestCreatedDomainEvents.Add(new CreatedRequestDomainEvent(Id, _requestItensEntities));
        }

        public void Validations(int clientId)
        {
            DefaultValidationsException.IsNullOrEmpty(clientId, nameof(clientId));
        }
    }
}
