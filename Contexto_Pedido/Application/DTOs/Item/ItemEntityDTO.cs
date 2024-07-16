using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Item
{
    public class ItemEntityDTO
    {
        public string Name { get; set; }
        public PriceItem PriceItem { get; set; }
        public QuantityItem QuantityItemStock { get; set; }
    }
}
