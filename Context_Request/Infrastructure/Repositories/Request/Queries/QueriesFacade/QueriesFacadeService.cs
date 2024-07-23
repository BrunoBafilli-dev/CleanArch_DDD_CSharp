using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.ReadQueries;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.UpdateQueries;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade
{
    public class QueriesFacadeService
    {
        private readonly RequestDataContext _requestDataContext;

        public QueriesFacadeService(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task CreateQueriesAsync(RequestEntity requestEntity)
        {
            CreateQueriesService queriesService = new CreateQueriesService(_requestDataContext);
        }

        public async Task ReadQueriesAsync(RequestEntity requestEntity)
        {
            ReadQueriesService readQueriesService = new ReadQueriesService(_requestDataContext);
        }

        public async Task UpdateQueriesAsync(RequestEntity requestEntity)
        {
            CreateQueriesService queriesService = new CreateQueriesService(_requestDataContext);
        }
    }
}
