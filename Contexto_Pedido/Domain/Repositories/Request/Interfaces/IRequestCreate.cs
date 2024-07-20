using Domain.Request.Entities.Request;

namespace Domain.Request.Repositories.Request.Interfaces
{
    public interface IRequestCreate
    {
        Task CreateRequestAsync(RequestEntity requestEntity);
    }
}
