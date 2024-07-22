using Application.Request.CQRS.Item.Commands;
using Domain.Request.Entities.Item;
using Domain.Request.Repositories;
using MediatR;

namespace Application.Request.CQRS.Item.Handlers.Command
{
    public class ItemUpdateCommandHandler : IRequestHandler<ItemUpdateCommand, ItemEntity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemUpdateCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ItemEntity> Handle(ItemUpdateCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.ItemRepository.UpdateItemsStockAsync(request.RequestItensEntities);

            await _unitOfWork.CommitAsync();

            return new ItemEntity();
        }
    }
}
