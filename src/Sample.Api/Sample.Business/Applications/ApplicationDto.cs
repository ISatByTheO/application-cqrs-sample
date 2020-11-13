using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Business.Applications
{
    public class ApplicationDto
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
