using Application.Stock.CQRS.Item.Commands;
using Domain.SharedKernel.Stock.Events.Events;
using MediatR;

namespace Application.Stock.Events.Item.Handlers.UpdatedItemReducedStockEventHandlers
{
    public class UpdatedItemReducedStockEventHandler : INotificationHandler<SKUpdatedStockDomainEvent>
    {
        private readonly IMediator _mediator;

        public UpdatedItemReducedStockEventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(SKUpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        {
            await _mediator.Send(new ItemUpdateStockReduceCommand(notification));
        }
    }
}
