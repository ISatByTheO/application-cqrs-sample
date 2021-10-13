using Microsoft.Extensions.DependencyInjection;

namespace Sample.Api.Configuration
{
    internal static class FluentValidationExtensions
    {
        internal static IMvcBuilder AddFluentValidtors(this IMvcBuilder mvcBuilder)
        {
            return mvcBuilder;
        }
    }
}
