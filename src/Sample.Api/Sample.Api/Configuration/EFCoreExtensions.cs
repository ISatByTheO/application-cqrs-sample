using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Domain.Applications;
using Sample.Infrastructure.Database;
using Sample.Infrastructure.Domain.Applications;

namespace Sample.Api.Configuration
{
    internal static class EFCoreExtensions
    {
        private const string _context = "applicationcontext";

        internal static IServiceCollection AddDatabaseContext(this IServiceCollection servicesCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection(_context).Value;

            servicesCollection.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connectionString));

            return servicesCollection;
        }

        internal static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IApplicationRepository, ApplicationRepository>();
            return serviceCollection;
        }
    }
}
