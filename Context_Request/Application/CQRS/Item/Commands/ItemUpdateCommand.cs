using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Item.Commands
{
    public class ItemUpdateCommand : IRequest<ItemEntity>
    {
        public List<RequestItemEntity> RequestItensEntities { get; set; }

        public ItemUpdateCommand(List<RequestItemEntity> requestItensEntities)
        {
            RequestItensEntities = requestItensEntities;
        }
    }
}
