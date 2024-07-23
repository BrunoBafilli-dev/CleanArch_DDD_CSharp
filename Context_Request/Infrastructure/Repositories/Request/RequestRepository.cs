using Domain.Request.Entities;
using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using Infrastructure.Request.Database.EntityFramework;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.Create;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.DeleteQueries;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.ReadQueries;
using Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.UpdateQueries;
using Microsoft.EntityFrameworkCore;
using Validations.Request;

namespace Infrastructure.Request.Repositories.Request
{
    public class RequestRepository : IRequestRepository
    {
        private readonly RequestDataContext _requestDataContext;

        private readonly CreateRequestQueryFacade _createRequestQueryFacade;
        private readonly ReadRequestQueryFacade _readRequestQueryFacade;
        private readonly UpdateRequestQueryFacade _updateRequestQueryFacade;
        private readonly DeleteRequestQueryFacade _deleteRequestQueryFacade;

        public RequestRepository(RequestDataContext requestDataContext)
        {
            _requestDataContext = requestDataContext;

            _createRequestQueryFacade = new CreateRequestQueryFacade(_requestDataContext);
            _readRequestQueryFacade = new ReadRequestQueryFacade(_requestDataContext);
            _updateRequestQueryFacade = new UpdateRequestQueryFacade(_requestDataContext);
            _deleteRequestQueryFacade = new DeleteRequestQueryFacade(_requestDataContext);
        }

        public async Task CreateRequestAsync(RequestEntity requestEntity)
            => _createRequestQueryFacade.CreateRequest(requestEntity);

        public async Task UpdateRequestAsync(RequestEntity requestEntity)
            => await _updateRequestQueryFacade.UpdateRequestAsync(requestEntity);

        public async Task DeleteRequestAsync(int id)
            => await _deleteRequestQueryFacade.DeleteRequestAsync(id);

        public async Task<RequestEntity> ReadRequestByIdAsync(int id)
        {
            return await _readRequestQueryFacade.ReadRequestByIdAsync(id);
        }
    }
}
