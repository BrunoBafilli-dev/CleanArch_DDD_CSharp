using Application.DTOs.Request;
using Application.Services.Request;
using Application.Services.Request.Interfaces;
using Domain.ValueObjects;
using Infrastructure.IOC.ContainerDI;


var _requestApplicationService = DIConfiguration.GetService<IRequestApplicationService>();

List<RequestItemEntityDTO> requestItemEntity = new List<RequestItemEntityDTO>()
{
    new RequestItemEntityDTO() { Name = "Produto B", ItemId = 2, PriceItem = new PriceItem(0.00M), QuantityItem = new QuantityItem(5) },
    new RequestItemEntityDTO() { Name = "Produto C", ItemId = 3, PriceItem = new PriceItem(0.00M), QuantityItem = new QuantityItem(3) },
    new RequestItemEntityDTO() { Name = "Produto A", ItemId = 4, PriceItem = new PriceItem(0.00M), QuantityItem = new QuantityItem(6) }
};
await _requestApplicationService.CreateRequestAsync(1, requestItemEntity);