using Domain.Request.Entities.Request;

namespace Domain.Request.Repositories.Request.Interfaces
{
    public interface IRequestUpdate
    {
        Task UpdateRequestAsync(RequestEntity requestEntity);
    }
}
