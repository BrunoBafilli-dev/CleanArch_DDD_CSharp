using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.UpdateQueries
{
    public class UpdateQueriesService
    {
        private readonly RequestDataContext _requestDataContext;

        public UpdateQueriesService(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task UpdateRequestAsync(RequestEntity requestEntity)
        {
            _requestDataContext.RequestEntities.Add(requestEntity);
        }
    }
}
