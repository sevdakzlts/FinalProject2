using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class CourierConfiguration : IEntityTypeConfiguration<Courier>
    {
        public void Configure(EntityTypeBuilder<Courier> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.FullName).IsRequired();
            builder.Property(c => c.FullName).HasMaxLength(EfCoreConstraintsConstants.NameMaxLenght);

            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(EfCoreConstraintsConstants.EmailMaxLenght);

            builder.Property(c => c.Phone).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(EfCoreConstraintsConstants.PhoneMaxLenght);


            builder.ToTable("Couriers");
        }
    }
}

