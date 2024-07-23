using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations.Request;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.DeleteQueries
{
    public class DeleteQueriesService
    {
        private readonly RequestDataContext _requestDataContext;

        public DeleteQueriesService(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task DeleteRequestAsync(int id)
        {
            var requestEntity = await _requestDataContext.RequestEntities.FindAsync(id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            _requestDataContext.RequestEntities.Remove(requestEntity);
        }
    }
}
