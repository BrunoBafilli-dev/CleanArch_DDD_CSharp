using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create
{
    public class CreateQueriesService
    {
        public static void CreateRequestAsync(RequestEntity requestEntity, RequestDataContext _requestDataContext)
        {
            _requestDataContext.RequestEntities.Add(requestEntity);
        }
    }
}
