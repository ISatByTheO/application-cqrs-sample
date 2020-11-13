using MediatR;
using Sample.Domain.Applications;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Business.Applications.GetApplication
{
    public class GetApplicationQueryHandler : IRequestHandler<GetApplicationQuery, ApplicationDto>
    {
        private readonly IApplicationRepository _applications;

        public GetApplicationQueryHandler(IApplicationRepository applications)
        {
            _applications = applications;
        }

        public async Task<ApplicationDto> Handle(GetApplicationQuery request, CancellationToken cancellationToken)
        {
            var application = await _applications.GetApplication(request.Id);

            if (application == null)
                return null;

            return new ApplicationDto
            {
                Id = application.Id,
                Firstname = application.Firstname,
                Lastname = application.Lastname,
                Email = application.Email,
                DateOfBirth = application.DateOfBirth
            };
        }
    }
}
