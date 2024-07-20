using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations;

namespace Domain.ValueObjects
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
