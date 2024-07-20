using Domain.Request.ValueObjects;

namespace Application.Request.DTOs.Request
{
    public class RequestItemEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public PriceItem PriceItem { get; set; }
        public QuantityItem QuantityItem { get; set; }
    }
}
