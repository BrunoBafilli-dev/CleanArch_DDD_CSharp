using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Request.Queries
{
    public class RequestQuery
    {
        public RequestItemEntity RequestItemEntity { get; protected set; }
    }
}
