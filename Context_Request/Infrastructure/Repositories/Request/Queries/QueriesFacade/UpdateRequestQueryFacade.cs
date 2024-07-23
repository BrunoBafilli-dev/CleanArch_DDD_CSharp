using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.DeleteQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.UpdateQueries;
using Domain.Request.Entities.Request;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade
{
    public class UpdateRequestQueryFacade
    {
        private readonly RequestDataContext _requestDataContext;

        public UpdateRequestQueryFacade(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task UpdateRequestAsync(RequestEntity requestEntity)
            => await UpdateQueriesService.ExecuteAsync(requestEntity, _requestDataContext);
    }
}
