using ECommerceApplication.Services;
using ECommerceInfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using RedisServiceExtension;

namespace ECommerceInfrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.UseRedis();

            serviceCollection.AddTransient<IRedisService, RedisService>();
        }
    }
}