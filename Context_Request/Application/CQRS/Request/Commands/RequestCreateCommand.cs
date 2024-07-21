using Application.Request.CQRS.Interfaces;
using Domain.Request.Entities.Request;

namespace Application.Request.CQRS.Request.Commands
{
    public class RequestCreateCommand : RequestCommand, ICQRS
    {
        public RequestCreateCommand(RequestEntity requestEntity)
        {
            RequestEntity = requestEntity;
        }
    }
}
