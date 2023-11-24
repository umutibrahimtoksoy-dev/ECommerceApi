using ECommerceApplication.Repositories.ICustomerRepository;
using ECommerceDomain.Entities;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.CustomerRepository
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
