using Domain.Request.ValueObjects;

namespace Application.Request.DTOs.Item
{
    public class ItemEntityDTO
    {
        public string Name { get; set; }
        public PriceItem PriceItem { get; set; }
        public QuantityItem QuantityItemStock { get; set; }
    }
}
