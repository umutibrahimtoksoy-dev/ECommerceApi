using ECommerceDomain.Entities.Common;

namespace ECommerceDomain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsActive { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> OrderProduct { get; set; }
    }
}
