using Sample.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Applications.Rules
{
    public class FirstnameShouldHaveALengthGreaterThanZero : IBusinessRule
    {
        public readonly string Firstname;

        public FirstnameShouldHaveALengthGreaterThanZero(string firstname)
        {
            Firstname = firstname;
        }

        public string Message => "Firstname must be a length greater than zero";

        public bool IsBroken() => Firstname.Length <= 0;
    }
}
