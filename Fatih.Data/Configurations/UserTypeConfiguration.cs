using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn();

            builder.Property(u => u.Customer).IsRequired();

            builder.Property(u => u.Seller).IsRequired();

            builder.ToTable("UserTypes");
        }
    }
}


