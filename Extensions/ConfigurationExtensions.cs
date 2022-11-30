using Microsoft.Extensions.Configuration;

namespace apiPrepTestingFramework.QA.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string baseUrl(this IConfiguration config)
        {
            return config.GetValue<string>("baseUrl");
        }

        public static string SSOTokenUrl(this IConfiguration config)
        {
            return config.GetValue<string>("SSOTokenUrl");
        }

        public static string DealershipId(this IConfiguration config) 
        {
            return config.GetValue<string>("DealershipId");
        }
    }
}