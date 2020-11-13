using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Application.Validators
{
    public class AddApplicationRequestValidator : AbstractValidator<AddApplicationRequest>
    {
        public AddApplicationRequestValidator()
        {
            RuleFor(x => x.Firstname)
                .NotNull()
                .WithMessage("Firstname cannot be null.");
                
            RuleFor(x => x.Lastname).NotNull();
            RuleFor(x => x.DateOfBirth)
                .LessThanOrEqualTo(DateTime.Now.AddYears(-19))
                .WithMessage("Applicant must be 19 years or older.");
        }
    }
}
