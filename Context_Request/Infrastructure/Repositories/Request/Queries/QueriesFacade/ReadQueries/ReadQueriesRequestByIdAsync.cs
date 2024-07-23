using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Validations.Request;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.ReadQueries
{
    public class ReadQueriesRequestByIdAsync
    {
        public static async Task<RequestEntity> ExecuteAsync(int id, RequestDataContext _requestDataContext)
        {
            var requestEntity = await _requestDataContext.RequestEntities
                .Include(r => r.RequestItensEntities)
                .FirstOrDefaultAsync(r => r.Id == id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            return requestEntity;
        }
    }
}
