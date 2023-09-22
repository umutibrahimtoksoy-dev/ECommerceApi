using Microsoft.Extensions.Configuration;

namespace ECommercePersistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceApi"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("ECommerceConnection");
            }
        }
    }
}
