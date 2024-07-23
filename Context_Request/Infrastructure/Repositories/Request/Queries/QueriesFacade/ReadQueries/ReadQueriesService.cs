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
    public class ReadQueriesService
    {
        private readonly RequestDataContext _requestDataContext;

        public ReadQueriesService(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;
        }

        public async Task<RequestEntity> ReadRequestByIdAsync(int id)
        {
            var requestEntity = await _requestDataContext.RequestEntities
                .Include(r => r.RequestItensEntities)
                .FirstOrDefaultAsync(r => r.Id == id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            return requestEntity;
        }
    }
}
