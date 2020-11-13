using Microsoft.Extensions.DependencyInjection;
using Sample.Api.Application.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Configuration
{
    internal static class Filters
    {
        internal static IMvcBuilder AddFilters(this IMvcBuilder builder)
        {
            builder.AddMvcOptions(options => options.Filters.Add(new ValidationFilter()));
            return builder;
        }
    }
}
