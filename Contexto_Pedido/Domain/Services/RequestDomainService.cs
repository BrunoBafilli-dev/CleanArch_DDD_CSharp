using Domain.Request.Entities.Request;
using Domain.Request.Services.Request.Interfaces;

namespace Domain.Request.Services
{
    public class RequestDomainService : IRequestDomainService
    {
        public RequestEntity CreateRequest(int clientId, ICollection<RequestItemEntity> requestItensEntities)
        {
            return new RequestEntity(clientId, requestItensEntities);
        }
    }
}
