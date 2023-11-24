using ECommerceDomain.Entities.Common;

namespace ECommerceDomain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
