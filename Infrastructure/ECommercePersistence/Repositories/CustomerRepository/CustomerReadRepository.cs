using ECommerceApplication.Repositories.ICustomerRepository;
using ECommerceDomain.Entities;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
