using Application.CQRS.Item.Commands;
using Application.CQRS.Request.Commands;
using Application.Events.EventBus;
using Domain.Entities.Request;
using Domain.UnitOfWork;
using MediatR;

namespace Application.CQRS.Request.Handlers.Commands
{
    public class RequestCreateCommandHandle : IRequestHandler<RequestCreateCommand, RequestEntity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventBus _eventBus;

        public RequestCreateCommandHandle(IUnitOfWork unitOfWork, IEventBus eventBus)
        {
            _unitOfWork = unitOfWork;
            _eventBus = eventBus;
        }

        public async Task<RequestEntity> Handle(RequestCreateCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.RequestRepository.CreateRequestAsync(request.RequestEntity);

            await _unitOfWork.CommitAsync(); // precisa enviar o commit depois dos eventos disparados. TALVEZ... 
            //PRECISA PENSAR MAIS.

            await RequestCreatedDispatchEvents(request.RequestEntity);

            return request.RequestEntity;
        }

        public async Task RequestCreatedDispatchEvents(RequestEntity requestEntity)
        {
            foreach (var @event in requestEntity.RequestCreatedDomainEvents)
            {
                await _eventBus.Publish(@event);
            }
        }
    }
}
