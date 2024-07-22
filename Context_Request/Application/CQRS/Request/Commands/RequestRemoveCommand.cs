using Application.Request.CQRS.Interfaces;
using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Commands
{
    public class RequestRemoveCommand : IRequest<Unit>, ICQRS
    {
        public int RequestId { get; set; }

        public RequestRemoveCommand(int id)
        {
            RequestId = id;
        }
    }
}
