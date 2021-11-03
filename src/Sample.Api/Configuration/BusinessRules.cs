using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Sample.Api.Configuration
{
    internal static class BusinessRules
    {
        internal static IServiceCollection AddBusinessRules(this IServiceCollection servicesCollection, IConfiguration configuration)
        {
            return servicesCollection;
        }
    }
}
