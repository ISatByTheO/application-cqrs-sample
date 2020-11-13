using MediatR;
using System;

namespace Sample.Business.Applications.GetApplication
{
    public class GetApplicationQuery : IRequest<ApplicationDto>
    {
        public Guid Id { get; private set; }

        public GetApplicationQuery(Guid id)
        {
            Id = id;
        }
    }
}
