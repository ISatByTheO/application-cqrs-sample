using Microsoft.Extensions.DependencyInjection;

namespace Sample.Api.Configuration
{
    internal static class Filters
    {
        internal static IMvcBuilder AddFilters(this IMvcBuilder builder)
        {
            return builder;
        }
    }
}
