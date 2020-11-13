using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Applications
{
    public interface IApplicationRepository
    {
        Task<Application> AddApplication(Application application);
        Task<Application> GetApplication(Guid Id);
    }
}
