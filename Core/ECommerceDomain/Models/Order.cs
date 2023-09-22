using ECommerceDomain.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDomain.Models
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public long Total { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
