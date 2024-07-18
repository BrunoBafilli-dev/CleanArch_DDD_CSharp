using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events.Request.Interfaces
{
    public interface IDomainEvent
    {
        public DateTime OcurredOn { get; }
    }
}
