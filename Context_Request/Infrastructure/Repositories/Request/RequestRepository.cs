using Domain.Request.Entities;
using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create;
using Microsoft.EntityFrameworkCore;
using Validations.Request;

namespace Infrastructure.Request.Repositories.Request
{
    public class RequestRepository : IRequestRepository
    {
        private readonly RequestDataContext _requestDataContext;
        //private readonly QueriesFacadeService _queriesFacadeService;

        public RequestRepository(RequestDataContext dataContext)
        {
            _requestDataContext = dataContext;
            //_queriesFacadeService = new QueriesFacadeService(dataContext);
        }

        //public async Task CreateQueries(RequestEntity requestEntity)
        //{
        //    await _queriesFacadeService.CreateQueriesAsync(requestEntity);
        //}

        //public async Task ReadQueries(RequestEntity requestEntity)
        //{
        //    await _queriesFacadeService.ReadQueriesAsync(requestEntity);
        //}

        //public async Task UpdateQueries(RequestEntity requestEntity)
        //{
        //    await _queriesFacadeService.UpdateQueriesAsync(requestEntity);
        //}

        public async Task CreateRequestAsync(RequestEntity requestEntity)
        {
            _requestDataContext.RequestEntities.Add(requestEntity);
        }

        public Task UpdateRequestAsync(RequestEntity requestEntity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRequestAsync(int id)
        {
            var requestEntity = await _requestDataContext.RequestEntities.FindAsync(id);

            DefaultValidationsException.IsNullOrEmpty(requestEntity, nameof(requestEntity));

            _requestDataContext.RequestEntities.Remove(requestEntity);
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
