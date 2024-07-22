using Validations.Request;

namespace Domain.Stock.ValueObjects
{
    public class QuantityItem
    {
        public int Quantity { get; private set; }

        public QuantityItem(int quantity)
        {
            DefaultValidationsException.IsNullOrEmpty(quantity, nameof(quantity));
            Quantity = quantity;
        }
    }
}
