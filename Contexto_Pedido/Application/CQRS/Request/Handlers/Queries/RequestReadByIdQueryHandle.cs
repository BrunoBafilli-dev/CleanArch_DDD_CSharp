using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Request.Queries;
using Domain.Entities.Request;
using Domain.Repositories.Request;
using Domain.UnitOfWork;
using MediatR;

namespace Application.CQRS.Request.Handlers.Queries
{
    public class RequestReadByIdQueryHandle : IRequestHandler<RequestReadByIdQuery, RequestEntity>
    {
        private readonly IRequestRepository _requestRepository;

        public RequestReadByIdQueryHandle(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<RequestEntity> Handle(RequestReadByIdQuery request, CancellationToken cancellationToken)
        {
           return await _requestRepository.ReadRequestByIdAsync(request.Id);
        }
    }
}
