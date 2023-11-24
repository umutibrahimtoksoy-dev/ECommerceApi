using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Entities;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
