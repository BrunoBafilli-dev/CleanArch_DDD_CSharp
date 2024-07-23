using Application.Request.CQRS.Request.Commands;
using Application.Request.Events.EventBus;
using Application.Request.Events.Request.Events;
using Application.Request.Events.Request.Saga;
using Domain.Request.Entities.Request;
using Domain.Request.Events.Request.Events;
using Domain.Request.Repositories;
using MediatR;

namespace Application.Request.CQRS.Request.Handlers.Commands
{
    public class RequestCreateCommandHandler : IRequestHandler<RequestCreateCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventBus _eventBus;
        private readonly IUpdateReduceStockSaga _updateReduceStockSaga;

        public RequestCreateCommandHandler(IUnitOfWork unitOfWork, IEventBus eventBus, IUpdateReduceStockSaga updateReduceStockSaga)
        {
            _unitOfWork = unitOfWork;
            _eventBus = eventBus;
            _updateReduceStockSaga = updateReduceStockSaga;
        }

        public async Task<Unit> Handle(RequestCreateCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.RequestRepository.CreateRequestAsync(request.RequestEntity);

            await _unitOfWork.CommitAsync();

            await _updateReduceStockSaga.UpdateStockOrCompensate(request.RequestEntity);

            return Unit.Value;
        }
    }
}
