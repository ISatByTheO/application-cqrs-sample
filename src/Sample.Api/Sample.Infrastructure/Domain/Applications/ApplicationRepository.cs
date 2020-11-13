using Microsoft.EntityFrameworkCore;
using Sample.Domain.Applications;
using Sample.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure.Domain.Applications
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ApplicationRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<Application> AddApplication(Application application)
        {
            _applicationContext.Applications.Add(application);
            await _applicationContext.SaveChangesAsync();
            return application;
        }

        public async Task<Application> GetApplication(Guid Id)
        {
            return await _applicationContext.Applications.FirstOrDefaultAsync(a => a.Id == Id);
        }
    }
}
