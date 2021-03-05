using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn();

            builder.Property(u=>u.City).IsRequired();
            builder.Property(u=>u.City).HasMaxLength(EfCoreConstraintsConstants.CityNameMaxLenght);

            builder.Property(u => u.Country).IsRequired();
            builder.Property(u => u.Country).HasMaxLength(EfCoreConstraintsConstants.CountryNameMaxLenght);

            builder.Property(u => u.Detail).IsRequired();
            builder.Property(u => u.Detail).HasMaxLength(EfCoreConstraintsConstants.AddressDetailMaxLenght);

            builder.ToTable("UserAddresses");
        }
    }
}


