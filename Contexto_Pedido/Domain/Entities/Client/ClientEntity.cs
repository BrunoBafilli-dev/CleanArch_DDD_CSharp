using Domain.Request.Entities.Interfaces;
using Domain.Request.ValueObjects;
using Validations;
using Validations.Request;

namespace Domain.Request.Entities.Client
{
    public class ClientEntity : Entity<int>, IAgregateRoot
    {
        //Public props
        public string Name { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<int> RequestsIds => _requestsIds; //Relationship - EF
        
        //Private props
        private List<int> _requestsIds;

        //Ctor
        public ClientEntity() {}//EF

        public ClientEntity(string name, Address address)
        {
            Validations(name);//Validations

            Name = name;
            Address = address;
            _requestsIds = new List<int>();
        }

        public void Validations(string name)
        {
            DefaultValidationsException.IsNullOrEmpty(name, nameof(name));
        }
    }
}
