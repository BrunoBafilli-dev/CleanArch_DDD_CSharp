using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using AutoMapper;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Domain.UnitOfWork;
using MediatR;

namespace Application.CQRS.Item.Handlers.Command
{
    public class ItemUpdateCommandHandle : IRequestHandler<ItemUpdateCommand, ItemEntity>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemUpdateCommandHandle(IUnitOfWork unitOfWork)
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
