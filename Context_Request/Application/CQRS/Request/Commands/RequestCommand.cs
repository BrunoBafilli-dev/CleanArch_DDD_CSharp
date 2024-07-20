using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Commands
{
    public abstract class RequestCommand : IRequest<RequestEntity>
    {
        public RequestEntity RequestEntity { get; protected set; }
    }
}
