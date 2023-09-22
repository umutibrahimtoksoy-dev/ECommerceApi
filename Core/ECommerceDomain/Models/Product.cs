using ECommerceDomain.Models.Common;

namespace ECommerceDomain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
