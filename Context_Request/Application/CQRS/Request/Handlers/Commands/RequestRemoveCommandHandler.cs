using Application.Request.Events.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.CQRS.Request.Commands;
using Domain.Request.Entities.Request;
using MediatR;
using Domain.Request.Repositories;

namespace Application.Request.CQRS.Request.Handlers.Commands
{
    public class RequestRemoveCommandHandler : IRequestHandler<RequestRemoveCommand, RequestEntity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestRemoveCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RequestEntity> Handle(RequestRemoveCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.RequestRepository.DeleteRequestAsync(request.RequestId);

            await _unitOfWork.CommitAsync();

            return new RequestEntity(1, new List<RequestItemEntity>());
        }
    }
}
