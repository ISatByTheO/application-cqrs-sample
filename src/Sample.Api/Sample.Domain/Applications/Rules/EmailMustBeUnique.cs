using Sample.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Applications.Rules
{
    public class EmailMustBeUnique : IBusinessRule
    {
        private readonly string Email;

        public EmailMustBeUnique(string email)
        {
            Email = email;
        }

        public string Message => "Email must be unique";

        public bool IsBroken()
        {
            return false;
        }
    }
}
