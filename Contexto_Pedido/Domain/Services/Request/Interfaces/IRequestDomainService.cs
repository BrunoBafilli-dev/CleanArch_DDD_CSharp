using Domain.Request.Entities.Request;

namespace Domain.Request.Services.Request.Interfaces
{
    public interface IRequestDomainService
    {
        public RequestEntity CreateRequest(int clientId, ICollection<RequestItemEntity> requestItensEntities);
    }
}
