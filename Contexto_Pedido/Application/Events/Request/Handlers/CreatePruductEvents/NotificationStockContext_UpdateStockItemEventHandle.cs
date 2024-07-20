using Domain.Request.Events.Request.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class NotificationStockContext_UpdateStockItemEventHandle : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IMediator _mediator;

        public NotificationStockContext_UpdateStockItemEventHandle(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            List<object> itemsEntities = new List<object>();

            foreach (var itemEntity in notification.RequestItensEntities)
            {
                itemsEntities.Add(itemEntity);
            }

            //await _mediator.Send(new ItemStockReduceUpdateCommand(itemsEntities));
        }
    }
}
