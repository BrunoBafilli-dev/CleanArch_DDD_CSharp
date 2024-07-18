using Application.CQRS.Item.Commands;
using Domain.Entities.Item;
using Domain.Repositories;
using MediatR;

namespace Application.CQRS.Item.Handlers.Command
{
    public class ItemUpdateCommandHandle : IRequestHandler<ItemStockReduceUpdateCommand, ItemEntity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemUpdateCommandHandle(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ItemEntity> Handle(ItemStockReduceUpdateCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.ItemRepository.UpdateItemsStockAsync(request.ItemsEntities);

            await _unitOfWork.CommitAsync();

            return new ItemEntity();
        }
    }
}
