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
    public class DeleteQueriesServiceAsync
    {
        public static async Task ExecuteAsync(int id, RequestDataContext _requestDataContext)
        {
            var requestEntity = await _requestDataContext.RequestEntities.FindAsync(id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            _requestDataContext.RequestEntities.Remove(requestEntity);
        }
    }
}
