using ECommerceDomain.Entities.Common;

namespace ECommerceDomain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}
