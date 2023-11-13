namespace ECommerceApplication.Services
{
    public interface IRedisService
    {
        Task SetProduct(string key, string value);
        Task<string> GetProduct(string key);
    }
}
