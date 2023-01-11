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

        public static string lenderServicesV3api(this IConfiguration config)
        {
            return config.GetValue<string>("lenderServicesV3api");
        }

        public static string lenderServiceV3ValidApiKey(this IConfiguration config)
        {
            return config.GetValue<string>("lenderServiceV3ValidApiKey");
        }

        public static string FirstNameCharacterLimitReached(this IConfiguration config)
        {
            return config.GetValue<string>("FirstNameCharacterLimitReached");
        }

        public static string QuoteWareVersionThreeQuoteEndpoint(this IConfiguration config)
        {
            return config.GetValue<string>("QuoteWareVersionThreeQuoteEndpoint");
        }
    }
}