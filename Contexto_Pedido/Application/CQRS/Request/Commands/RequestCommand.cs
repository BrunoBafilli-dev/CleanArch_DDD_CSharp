using Domain.Events.Request.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Request;
using MediatR;

namespace Application.CQRS.Request.Commands
{
    public abstract class RequestCommand : IRequest<RequestEntity>
    {
        public RequestEntity RequestEntity { get; protected set; }
    }
}
