using Domain.Request.Entities.Request;

namespace Domain.Request.Repositories.Request.Interfaces
{
    public interface IRequestRead
    {
        Task<RequestEntity> ReadRequestByIdAsync(int id);
    }
}
