using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Domain.Events.Request.Interfaces;
using MediatR;

namespace Domain.Events.Request.Events
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
