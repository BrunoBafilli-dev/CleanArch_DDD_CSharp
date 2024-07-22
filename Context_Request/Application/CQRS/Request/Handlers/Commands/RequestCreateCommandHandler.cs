using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.EventBus;
using Domain.Request.Entities.Request;
using Domain.Request.Events.Request.Events;
using Domain.Request.Repositories;
using MediatR;

namespace Application.Request.CQRS.Request.Handlers.Commands
{
    public class RequestCreateCommandHandler : IRequestHandler<RequestCreateCommand, RequestEntity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventBus _eventBus;

        public RequestCreateCommandHandler(IUnitOfWork unitOfWork, IEventBus eventBus)
        {
            _unitOfWork = unitOfWork;
            _eventBus = eventBus;
        }

        public async Task<RequestEntity> Handle(RequestCreateCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.RequestRepository.CreateRequestAsync(request.RequestEntity);

            await _unitOfWork.CommitAsync();

            await TryUpdateStockContext(request.RequestEntity);

            return request.RequestEntity;
        }

        public async Task TryUpdateStockContext(RequestEntity requestEntity)
        {
            try
            {
                await RequestCreatedDispatchEvents(requestEntity);
            }
            catch (Exception e)
            {
                await CompensationEventDispatchEvent(requestEntity);
                throw;
            }
        }

        public async Task RequestCreatedDispatchEvents(RequestEntity requestEntity)
        {
            foreach (var @event in requestEntity.RequestCreatedDomainEvents)
            {
                await _eventBus.Publish(@event);
            }
        }

        public async Task CompensationEventDispatchEvent(RequestEntity requestEntity)
        {
            await _eventBus.Publish(new CompensationRequestDeleteDomainEvent(requestEntity.Id));
        }
    }
}
