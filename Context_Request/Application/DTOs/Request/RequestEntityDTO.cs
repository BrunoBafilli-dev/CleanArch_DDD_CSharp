using Domain.Request.Entities.Request;

namespace Application.Request.DTOs.Request
{
    public class RequestEntityDTO
    {
        public int ClientId { get; set; }
        public IReadOnlyCollection<RequestItemEntity> RequestItensEntities { get; set; }
    }
}
