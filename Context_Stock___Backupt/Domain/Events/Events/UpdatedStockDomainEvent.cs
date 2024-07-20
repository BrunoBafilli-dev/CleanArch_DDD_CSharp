using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Request.Interfaces;
using MediatR;

namespace Domain.Events.Events
{
    public class UpdatedStockDomainEvent : IDomainEvent, INotification
    {
        public int Id { get; private set; }
        public int RemoveQuantity { get; private set; }
        public DateTime OcurredOn { get; private set; }

        public UpdatedStockDomainEvent(int id, int removeQuantity, DateTime ocurredOn)
        {
            Id = id;
            RemoveQuantity = removeQuantity;
            OcurredOn = ocurredOn;
        }
    }
}
