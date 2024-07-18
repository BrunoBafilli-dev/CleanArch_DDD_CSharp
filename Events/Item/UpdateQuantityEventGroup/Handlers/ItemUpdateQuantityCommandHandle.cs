using Domain.Entities.Item;
using MediatR;
using SharedKernel.Events.Item.UpdateQuantityEventGroup.Commands;

namespace SharedKernel.Events.Item.UpdateQuantityEventGroup.Handlers
{
    public class ItemUpdateQuantityCommandHandle : IRequestHandler<ItemUpdateQuantityCommand, ItemEntity>
    {
        private readonly IMediator _mediator;

        public ItemUpdateQuantityCommandHandle(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ItemEntity> Handle(ItemUpdateQuantityCommand request, CancellationToken cancellationToken)
        {
            // Log the request occurrence time - consider using a logging framework instead of throwing an exception
            Console.WriteLine("Request Occurred On: " + request.OcurredOn.ToString());

            // Simulate some processing logic
            // Assumindo que ItemEntity tem um construtor adequado
            var itemEntity = new ItemEntity("teste", 5, 5); // Criando uma nova instância de ItemEntity

            return await Task.FromResult(itemEntity); // Retornando a instância como uma Task
        }


        //public async Task Handle(UpdatedStockDomainEvent notification, CancellationToken cancellationToken)
        //{
        //    var itemUpdateCommand = new ItemStockReduceUpdateCommand(notification);

        //    await _mediator.Send(itemUpdateCommand, cancellationToken);
        //}
    }
}
