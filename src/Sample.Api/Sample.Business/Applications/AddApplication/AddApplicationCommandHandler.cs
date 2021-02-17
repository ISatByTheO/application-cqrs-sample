using MediatR;
using Sample.Domain.Applications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Business.Applications.AddApplication
{
    public class AddApplicationCommandHandler : IRequestHandler<AddApplicationCommand, ApplicationDto>
    {
        private readonly IApplicationRepository _applciations;

        public AddApplicationCommandHandler(IApplicationRepository applciations)
        {
            _applciations = applciations;
        }

        public async Task<ApplicationDto> Handle(AddApplicationCommand request, CancellationToken cancellationToken)
        {
            var application = Application.AddApplication(request.Firstname, request.Lastname, request.Email, request.DateOfBirth);

            await _applciations.AddApplication(application);

            return new ApplicationDto 
            { 
                Id = application.Id, 
                Firstname = application.Firstname, 
                Lastname = application.Lastname, 
                DateOfBirth = application.DateOfBirth, 
                Email = application.Email 
            };
        }
    }
}
