using Application.Request.CQRS.Interfaces;
using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Commands
{
    public abstract class RequestCommand : IRequest<RequestEntity>, ICQRS
    {
        public RequestEntity RequestEntity { get; protected set; }
    }
}
