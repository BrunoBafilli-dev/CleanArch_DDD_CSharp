using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.ReadQueries;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade
{
    public class ReadRequestQueryFacade
    {
        private readonly RequestDataContext _requestDataContext;

        public ReadRequestQueryFacade(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task<RequestEntity> ReadRequestByIdAsync(int id)
        {
            return await ReadQueriesRequestByIdAsync.ExecuteAsync(id, _requestDataContext);
        }
    }
}