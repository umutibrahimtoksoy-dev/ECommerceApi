using RedisServiceExtension.Services;

namespace ECommerceInfrastructure.Services
{
    public class RedisService : ECommerceApplication.Services.IRedisService
    {
        private readonly IRedisService _redisService;

        public RedisService(IRedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task SetProduct(string key, string value)
        {
            await _redisService.SetString(key, value);
        }

        public async Task<string> GetProduct(string key)
        {
            return await _redisService.Get(key);
        }
    }
}
