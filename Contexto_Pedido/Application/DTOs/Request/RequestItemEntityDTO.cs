using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
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
