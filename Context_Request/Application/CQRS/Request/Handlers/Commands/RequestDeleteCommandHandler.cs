using Application.Request.Events.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.Request.Handlers.CompensationRequestEventHandlers;
using Domain.Request.Entities.Request;
using Domain.Request.UnitOfWork;
using MediatR;

namespace Application.Request.CQRS.Request.Handlers.Commands
{
    public class RequestDeleteCommandHandler : IRequestHandler<RequestRemoveCommand, RequestEntity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestDeleteCommandHandler(IUnitOfWork unitOfWork)
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
