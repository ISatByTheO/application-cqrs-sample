using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Domain.Applications.Settings;

namespace Sample.Api.Configuration
{
    internal static class BusinessRules
    {
        internal static IServiceCollection AddBusinessRules(this IServiceCollection servicesCollection, IConfiguration configuration)
        {
            servicesCollection.Configure<ApplicationSettings>(
                dataSettings => configuration.GetSection(typeof(ApplicationSettings).Name));

            return servicesCollection;
        }
    }
}
