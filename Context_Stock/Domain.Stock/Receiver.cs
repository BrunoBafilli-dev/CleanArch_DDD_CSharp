using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Shared_Kernel.Stock.Events;
using MediatR;

namespace Domain.Stock
{
    public class Receiver : INotificationHandler<UpdatedStockDomainEvent>
    {
        public Task Handle(UpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("fon");

            return Task.CompletedTask;
        }
    }
}
