using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Request;
using Domain.Repositories.Request;
using Domain.ValueObjects;
using Infrastructure.Database.EntityFramework;
using Infrastructure.Repositories.Request.Queries;
using Microsoft.EntityFrameworkCore;
using Validations;

namespace Infrastructure.Repositories.Request
{
    public class RequestRepository : IRequestRepository
    {
        private readonly DataContext _dataContext;

        public RequestRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateRequestAsync(RequestEntity requestEntity)
        {
            await StockAvailabilityQuery.StockAvailabilityAndAdjustment(requestEntity, _dataContext);

            _dataContext.RequestEntities.Add(requestEntity);
        }

        public Task UpdateRequestAsync(RequestEntity requestEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRequestAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RequestEntity> ReadRequestByIdAsync(int id)
        {
            var requestEntity = await _dataContext.RequestEntities
                .Include(r => r.RequestItensEntities)
                .FirstOrDefaultAsync(r => r.Id == id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            return requestEntity;
        }
    }
}
