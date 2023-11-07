using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Models;
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
