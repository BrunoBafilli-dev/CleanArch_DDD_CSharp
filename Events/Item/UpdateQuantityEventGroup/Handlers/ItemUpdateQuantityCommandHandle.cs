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

            //_mediator.Send(new ItemStock)

            var itemEntity = new ItemEntity("teste", 5, 5); // Criando uma nova instância de ItemEntity

            return await Task.FromResult(itemEntity); // Retornando a instância como uma Task
        }
    }
}
