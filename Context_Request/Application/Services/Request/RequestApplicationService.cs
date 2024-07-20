using Application.Request.CQRS.Request.Commands;
using Application.Request.CQRS.Request.Queries;
using Application.Request.DTOs.Request;
using Application.Services.Request;
using Application.Services.Request.Interfaces;
using Domain.Request.Entities.Request;

namespace Application.Request.Services.Request
{
    public class RequestApplicationService : IRequestApplicationService
    {
        private readonly RequestApplicationServiceDependencies _requestServiceDependencies;

        public RequestApplicationService(RequestApplicationServiceDependencies requestServiceDependencies)
        {
            _requestServiceDependencies = requestServiceDependencies;
        }

        public async Task CreateRequestAsync(int clientId, ICollection<RequestItemEntityDTO> requestItemEntityDTO)
        {
            var requestItensEntities = _requestServiceDependencies._mapper.Map<ICollection<RequestItemEntity>>(requestItemEntityDTO);

            var requestEntity = _requestServiceDependencies._requestDomainService.CreateRequest(clientId, requestItensEntities);

            await _requestServiceDependencies._mediator.Send(new RequestCreateCommand(requestEntity));
        }

        public async Task<RequestEntityDTO> ReadRequestByIdAsync(int requestId)
        {
            var requestEntity = await _requestServiceDependencies._mediator.Send(new RequestReadByIdQuery(requestId));

            return _requestServiceDependencies._mapper.Map<RequestEntityDTO>(requestEntity);
        }
    }
}
