using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using Application.CQRS.Request.Commands;
using Application.DTOs.Request;
using Domain.Entities.Item;
using Domain.Entities.Request;

namespace Application.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Mapeamentos DTOs para Entity
            CreateMap<RequestItemEntityDTO, RequestItemEntity>()
                .ConstructUsing(dto =>
                    new RequestItemEntity(dto.Name, dto.ItemId, dto.PriceItem.Price, dto.QuantityItem.Quantity))
                .ReverseMap();

            CreateMap<RequestEntityDTO, RequestEntity>().ReverseMap();


            ////////////////////////////////////////////////////////

            //Mapeamento CQRS, Commands para Entity

            //Requests
            CreateMap<RequestCreateCommand, RequestEntity>().ReverseMap();

            //Items
            CreateMap<ItemUpdateCommand, ItemEntity>().ReverseMap();
        }
    }
}
