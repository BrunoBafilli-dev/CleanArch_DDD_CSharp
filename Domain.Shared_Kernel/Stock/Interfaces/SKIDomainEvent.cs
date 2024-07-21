using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared_Kernel.Stock.Interfaces
{
    public interface SKIDomainEvent
    {
        public DateTime OcurredOn { get; }
    }
}
