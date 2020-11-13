using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Sample.Api.Application.Validators;

namespace Sample.Api.Configuration
{
    internal static class FluentValidationExtensions
    {
        internal static IMvcBuilder AddFluentValidtors(this IMvcBuilder mvcBuilder)
        {
            mvcBuilder.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddApplicationRequestValidator>());

            return mvcBuilder;
        }
    }
}
