using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Domain.ValueObjects;
using MediatR;

namespace Application.CQRS.Item.Commands
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
