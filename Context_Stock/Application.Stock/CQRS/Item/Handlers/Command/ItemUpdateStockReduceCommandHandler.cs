using Application.Stock.CQRS.Item.Commands;
using Domain.Stock.Entities.Item;
using Domain.Stock.Repositories;
using MediatR;

namespace Application.Stock.CQRS.Item.Handlers.Command
{
    public class ItemUpdateStockReduceCommandHandler
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemUpdateStockReduceCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ItemEntity> Handle(ItemUpdateStockReduceCommand request, CancellationToken cancellationToken)
        {
            await UpdateStockForItemsAsync(request);

            await _unitOfWork.CommitAsync();

            return new ItemEntity();
        }

        private async Task UpdateStockForItemsAsync(ItemUpdateStockReduceCommand request)
        {
            foreach (var skItemStockUpdate in request.SKUpdatedStockDomainEvent.SKItemStockUpdate)
            {
                await _unitOfWork.ItemRepository.UpdateItemsStockAsync(skItemStockUpdate.ItemId, skItemStockUpdate.QuantityItem);
            }
        }
    }

}
