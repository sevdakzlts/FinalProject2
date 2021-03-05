using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn();

            builder.Property(u => u.FullName).IsRequired();
            builder.Property(u => u.FullName).HasMaxLength(EfCoreConstraintsConstants.NameMaxLenght);

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(EfCoreConstraintsConstants.EmailMaxLenght);

            builder.Property(u => u.Phone).IsRequired();
            builder.Property(u => u.Phone).HasMaxLength(EfCoreConstraintsConstants.PhoneMaxLenght);

            builder.Property(u => u.LoginName).IsRequired();
            builder.Property(u => u.LoginName).HasMaxLength(EfCoreConstraintsConstants.NameMaxLenght);

            builder.Property(u => u.LoginPassword).IsRequired();
            builder.Property(u => u.LoginPassword).HasMaxLength(EfCoreConstraintsConstants.PasswordMaxLenght);

            builder.ToTable("Users");
        }
    }
}
