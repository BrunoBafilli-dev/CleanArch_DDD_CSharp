using Domain.Request.Entities;
using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries;
using Microsoft.EntityFrameworkCore;
using Validations;
using Validations.Request;

namespace Infrastructure.Request.Repositories.Request
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

        public async Task DeleteRequestAsync(int id)
        {
            var requestEntity = await _dataContext.RequestEntities.FindAsync(id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            _dataContext.RequestEntities.Remove(requestEntity);
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
