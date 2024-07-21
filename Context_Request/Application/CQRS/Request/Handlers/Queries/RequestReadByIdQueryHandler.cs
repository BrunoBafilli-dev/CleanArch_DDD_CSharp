using Application.Request.CQRS.Request.Queries;
using Domain.Request.Entities.Request;
using Domain.Request.Repositories.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Handlers.Queries
{
    public class RequestReadByIdQueryHandler : IRequestHandler<RequestReadByIdQuery, RequestEntity>
    {
        private readonly IRequestRepository _requestRepository;

        public RequestReadByIdQueryHandler(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<RequestEntity> Handle(RequestReadByIdQuery request, CancellationToken cancellationToken)
        {
           return await _requestRepository.ReadRequestByIdAsync(request.Id);
        }
    }
}
