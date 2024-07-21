using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Request.Events.Request.Interfaces;
using MediatR;

namespace Domain.Request.Events.Request.Events
{
    public class CompensationRequestDeleteDomainEvent : INotification, IDomainEvent
    {
        public int RequestId { get; set; }
        public DateTime OcurredOn { get; set; }

        public CompensationRequestDeleteDomainEvent(int requestId)
        {
            RequestId = requestId;
        }
    }
}
