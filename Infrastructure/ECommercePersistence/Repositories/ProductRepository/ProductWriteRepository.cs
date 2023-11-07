using ECommerceApplication.Repositories.IProductRepository;
using ECommerceDomain.Models;
using ECommercePersistence.Contexts;

namespace ECommercePersistence.Repositories.ProductRepository
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext)
        {
        }
    }
}
