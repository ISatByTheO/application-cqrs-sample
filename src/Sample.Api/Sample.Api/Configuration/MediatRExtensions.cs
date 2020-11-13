using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Sample.Api.Configuration
{
    internal static class MediatRExtensions
    {
        private const string _assemblyName = "Sample.Business";

        internal static IServiceCollection AddMediatR(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(AppDomain.CurrentDomain.Load(_assemblyName));
            return serviceCollection;
        }
    }
}
