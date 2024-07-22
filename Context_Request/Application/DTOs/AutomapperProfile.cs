using AutoMapper;
using Application.Request.CQRS.Request.Commands;
using Application.Request.DTOs.Request;
using Domain.Request.Entities.Request;

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
        }
    }
}
