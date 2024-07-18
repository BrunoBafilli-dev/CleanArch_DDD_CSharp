using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events.Request.Interfaces
{
    public interface IDomainEvent
    {
        public int Id { get; }
        public DateTime OcurredOn { get; }
    }
}
