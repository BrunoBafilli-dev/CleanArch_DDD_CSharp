using Domain.Request.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade
{
    public class CreateRequestQueryFacade
    {
        private readonly RequestDataContext _requestDataContext;

        public CreateRequestQueryFacade(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public void CreateRequest(RequestEntity requestEntity)
            => CreateQueriesService.CreateRequestAsync(requestEntity, _requestDataContext);
    }
}
