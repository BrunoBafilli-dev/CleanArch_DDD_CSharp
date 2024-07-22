using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Stock.Entities
{
    public abstract class Entity<TIdentity>
    {
        public TIdentity Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
