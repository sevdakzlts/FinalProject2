using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class CourierAddressConfiguration : IEntityTypeConfiguration<CourierAddress>
    {
        public void Configure(EntityTypeBuilder<CourierAddress> builder)
        {
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Id).UseIdentityColumn();

            builder.Property(ca => ca.City).IsRequired();
            builder.Property(ca => ca.City).HasMaxLength(EfCoreConstraintsConstants.CityNameMaxLenght);

            builder.Property(ca => ca.Country).IsRequired();
            builder.Property(ca => ca.Country).HasMaxLength(EfCoreConstraintsConstants.CountryNameMaxLenght);

            builder.Property(ca => ca.Detail).IsRequired();
            builder.Property(ca => ca.Detail).HasMaxLength(EfCoreConstraintsConstants.AddressDetailMaxLenght);


            
            builder.ToTable("CourierAddresses");
        }
    }
}



