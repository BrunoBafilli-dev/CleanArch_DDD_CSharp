using Validations.Request;

namespace Domain.Stock.ValueObjects
{
    public class PriceItem
    {
        public decimal Price { get; private set; }

        public PriceItem(decimal price)
        {
            DefaultValidationsException.IsNullOrEmpty(price, nameof(price));
            Price = price;
        }
    }
}
