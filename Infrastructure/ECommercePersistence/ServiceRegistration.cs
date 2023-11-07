using ECommerceApplication.Repositories.ICustomerRepository;
using ECommerceApplication.Repositories.IOrderRepository;
using ECommerceApplication.Repositories.IProductRepository;
using ECommercePersistence.Contexts;
using ECommercePersistence.Repositories.CustomerRepository;
using ECommercePersistence.Repositories.OrderRepository;
using ECommercePersistence.Repositories.ProductRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommercePersistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<ICustomerReadRepository, CustomerReadRepository>();
            serviceCollection.AddTransient<ICustomerWriteRepository, CustomerWriteRepository>();

            serviceCollection.AddTransient<IOrderReadRepository, OrderReadRepository>();
            serviceCollection.AddTransient<IOrderWriteRepository, OrderWriteRepository>();

            serviceCollection.AddTransient<IProductReadRepository, ProductReadRepository>();
            serviceCollection.AddTransient<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}