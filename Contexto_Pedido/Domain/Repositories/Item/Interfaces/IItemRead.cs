using Domain.Request.Entities.Request;

namespace Domain.Request.Repositories.Item.Interfaces
{
    public interface IItemRead
    {
        Task<RequestEntity> ReadItemByIdAsync(int id);
    }
}
