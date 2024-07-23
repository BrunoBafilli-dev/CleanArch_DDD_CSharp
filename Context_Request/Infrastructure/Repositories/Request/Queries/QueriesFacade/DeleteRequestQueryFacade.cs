using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.DeleteQueries;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade
{
    public class DeleteRequestQueryFacade
    {
        private readonly RequestDataContext _requestDataContext;

        public DeleteRequestQueryFacade(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task DeleteRequestAsync(int id)
            => await DeleteQueriesServiceAsync.ExecuteAsync(id, _requestDataContext);
    }
}
