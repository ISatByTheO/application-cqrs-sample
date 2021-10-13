using Microsoft.Extensions.DependencyInjection;

namespace Sample.Api.Configuration
{
    internal static class MediatRExtensions
    {
        private const string _assemblyName = "Sample.Business";

        internal static IServiceCollection AddMediatR(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
