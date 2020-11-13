using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Business.Applications.AddApplication
{
    public class AddApplicationCommand : IRequest<ApplicationDto>
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public AddApplicationCommand(string firstname, string lastname, string email, DateTime dateOfBirth)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
    }
}
