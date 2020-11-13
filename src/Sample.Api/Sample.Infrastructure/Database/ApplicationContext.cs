using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sample.Domain.Applications;
using Sample.Infrastructure.Database.EntityConfigurations;
using System;

namespace Sample.Infrastructure.Database
{
    public class ApplicationContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "application";
        public DbSet<Application> Applications { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationEntityTypeConfiguration());
        }
    }

    public class ApplicationContextDesignFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("applicationcontext");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("Sample.Infrastructure"));

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
