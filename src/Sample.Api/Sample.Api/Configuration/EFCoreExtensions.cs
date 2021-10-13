using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Api.Configuration
{
    internal static class EFCoreExtensions
    {
        private const string _context = "applicationcontext";

        internal static IServiceCollection AddDatabaseContext(this IServiceCollection servicesCollection, IConfiguration configuration)
        {
            return servicesCollection;
        }

        internal static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
