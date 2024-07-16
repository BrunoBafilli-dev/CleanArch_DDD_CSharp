using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.Entities.Interfaces;
using Domain.ValueObjects;
using Validations;

namespace Domain.Entities.Client
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
