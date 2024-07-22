
using Application.Request.DTOs.Request;
using Application.Services.Request.Interfaces;
using ContainerDI.StartCore;
using Domain.Request.ValueObjects;
using FluentAssertions;
using Infrastructure.IOC.Request.ContainerDI;

namespace Testes.Request
{
    public class UnitTest1
    {
        private readonly IRequestApplicationService _requestApplicationService;

        public UnitTest1()
        {
            _requestApplicationService = DIConfiguration.GetService<IRequestApplicationService>();
        }

        [Fact]
        public async Task CreateRequestAsync()
        {
            List<RequestItemEntityDTO> requestItemEntity = new List<RequestItemEntityDTO>()
            {
                new RequestItemEntityDTO() { Name = "Produto A", ItemId = 1, PriceItem = new PriceItem(25.50M), QuantityItem = new QuantityItem(1) },
                new RequestItemEntityDTO() { Name = "Produto B", ItemId = 2, PriceItem = new PriceItem(15.75M), QuantityItem = new QuantityItem(2) },
                new RequestItemEntityDTO() { Name = "Produto C", ItemId = 3, PriceItem = new PriceItem(35.00M), QuantityItem = new QuantityItem(3) }
            };
            await _requestApplicationService.CreateRequestAsync(1, requestItemEntity);
        }

        [Fact]
        public async Task ReadRequestByIdAsync()
        {
            var request = await _requestApplicationService.ReadRequestByIdAsync(5);

            request.RequestItensEntities.Count.Should().BeGreaterThan(0);
        }
    }
}