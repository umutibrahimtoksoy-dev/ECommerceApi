using ECommerceDomain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDomain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public float Total { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
