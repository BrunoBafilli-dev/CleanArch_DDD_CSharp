using Application.DTOs.Request;
using Application.Services.Request.Interfaces;
using Domain.Entities.Request;
using Domain.ValueObjects;
using Infrastructure.IOC.ContainerDI;

var requestApplicationService = DIConfiguration.GetService<IRequestApplicationService>();


RequestItemEntityDTO requestItemEntity = new RequestItemEntityDTO(){Name ="batata", ItemId = 1, PriceItem = new PriceItem(20), QuantityItem = new QuantityItem(20)  };


//  public string Name { get; private set; }
// public int ItemId { get; private set; }
// public QuantityItem QuantityItem { get; private set; }
// public PriceItem PriceItem { get; private set; }

requestApplicationService.CreateRequestAsync(1, requestItemEntity);