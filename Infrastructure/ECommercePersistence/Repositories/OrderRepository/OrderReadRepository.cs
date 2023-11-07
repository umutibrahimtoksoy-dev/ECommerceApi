using ECommerceApplication.Repositories.IOrderRepository;
using ECommerceDomain.Models;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.OrderRepository
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
