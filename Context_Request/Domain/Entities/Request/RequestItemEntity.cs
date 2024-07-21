using Domain.Request.ValueObjects;
using Validations;
using Validations.Request;

namespace Domain.Request.Entities.Request
{
    public class RequestItemEntity : Entity<int>
    {
        //Public props
        public string Name { get; private set; }
        public int ItemId { get; set; }
        public QuantityItem QuantityItem { get; private set; }
        public PriceItem PriceItem { get; private set; }

        public RequestEntity RequestEntity { get; set; } //Relationship - EF
        public int RequestId { get; set; } //Relationship - EF

        //Ctor
        public RequestItemEntity() { }//EF

        public RequestItemEntity(string name, int itemId, decimal priceItem, int quantityItem)
        {
            //Validations
            Validations(name, itemId, priceItem, quantityItem);

            //Props
            Name = name;
            ItemId = itemId;
            PriceItem = new PriceItem(priceItem);
            QuantityItem = new QuantityItem(quantityItem);
        }

        public void Validations(string name, int itemId, decimal priceItem, int quantityItem)
        {
            DefaultValidationsException.IsNullOrEmpty(name, nameof(name));
            DefaultValidationsException.IsNullOrEmpty(itemId, nameof(itemId));
            DefaultValidationsException.IsNullOrEmpty(priceItem, nameof(priceItem));
            DefaultValidationsException.IsNullOrEmpty(quantityItem, nameof(quantityItem));
        }
    }
}
