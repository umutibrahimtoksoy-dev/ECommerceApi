using ECommerceApplication.Repositories.IOrderRepository;
using ECommerceDomain.Entities;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.OrderRepository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
