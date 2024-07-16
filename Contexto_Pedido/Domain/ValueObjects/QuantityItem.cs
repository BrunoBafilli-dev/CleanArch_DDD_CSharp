using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations;

namespace Domain.ValueObjects
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
