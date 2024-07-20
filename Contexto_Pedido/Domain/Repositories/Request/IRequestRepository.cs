using Domain.Request.Repositories.Request.Interfaces;

namespace Domain.Request.Repositories.Request
{
    public interface IRequestRepository : IRequestCreate, IRequestUpdate, IRequestDelete, IRequestRead
    {

    }
}
