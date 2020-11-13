using Sample.Domain.Applications.Rules;
using Sample.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Sample.Domain.Applications
{
    public class Application : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Application(string firstname, string lastname, string email, DateTime dateOfBirth) : base (Guid.NewGuid())
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public static Application AddApplication(string firstname, string lastname, string email, DateTime dateOfBirth)
        {
            CheckRule(new FirstnameShouldHaveALengthGreaterThanZero(firstname));
            CheckRule(new EmailMustBeUnique(email));

            return new Application(firstname, lastname, email, dateOfBirth);
        }
        
    }
}
