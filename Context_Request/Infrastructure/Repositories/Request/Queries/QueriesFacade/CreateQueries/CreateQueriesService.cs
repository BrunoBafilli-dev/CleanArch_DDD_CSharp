using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create
{
    public class CreateQueriesService
    {
        private readonly RequestDataContext _requestDataContext;

        public CreateQueriesService(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task CreateRequestAsync(RequestEntity requestEntity)
        {
            _requestDataContext.RequestEntities.Add(requestEntity);
        }
    }
}
