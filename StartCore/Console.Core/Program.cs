using Application.Request.DTOs.Request;
using Application.Services.Request.Interfaces;
using ContainerDI.Core;
using Domain.Request.ValueObjects;
using Infrastructure.IOC.Request.ContainerDI;

var _requestApplicationService = DIConfiguration.GetService<IRequestApplicationService>();

List<RequestItemEntityDTO> requestItemEntity = new List<RequestItemEntityDTO>()
{
    new RequestItemEntityDTO() { Name = "Produto A", ItemId = 1, PriceItem = new PriceItem(25.50M), QuantityItem = new QuantityItem(1) },
    new RequestItemEntityDTO() { Name = "Produto B", ItemId = 2, PriceItem = new PriceItem(15.75M), QuantityItem = new QuantityItem(2) },
    new RequestItemEntityDTO() { Name = "Produto C", ItemId = 3, PriceItem = new PriceItem(35.00M), QuantityItem = new QuantityItem(3) }
};
await _requestApplicationService.CreateRequestAsync(1, requestItemEntity);

Console.WriteLine("console core");