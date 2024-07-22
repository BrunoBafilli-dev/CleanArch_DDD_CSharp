using Application.Request.CQRS.Interfaces;
using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Commands
{
    public class RequestCreateCommand : IRequest<Unit>, ICQRS
    {
        public RequestEntity RequestEntity { get; protected set; }

        public RequestCreateCommand(RequestEntity requestEntity)
        {
            RequestEntity = requestEntity;
        }
    }
}
