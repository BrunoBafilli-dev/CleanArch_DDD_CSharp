using Domain.Request.Entities.Request;

namespace Application.Request.CQRS.Request.Commands
{
    public class RequestCreateCommand : RequestCommand
    {
        public RequestCreateCommand(RequestEntity requestEntity)
        {
            RequestEntity = requestEntity;
        }
    }
}
