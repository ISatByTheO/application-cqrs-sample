using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Applications;

namespace Sample.Infrastructure.Database.EntityConfigurations
{
    public class ApplicationEntityTypeConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Application", ApplicationContext.DEFAULT_SCHEMA);

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.DateOfBirth)
                .IsRequired();

            builder.Property(a => a.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Lastname)
                .HasMaxLength(50)
                .IsRequired();

            //You can apply foreign keys here.
        }
    }
}
