using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(EfCoreConstraintsConstants.NameMaxLenght);

            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(EfCoreConstraintsConstants.DescriptionMaxLenght);

            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Price).HasColumnType(EfCoreConstraintsConstants.PriceConfig);

            builder.Property(p => p.Image).HasMaxLength(EfCoreConstraintsConstants.ImageMaxLenght);

            builder.ToTable("Products");
        }
    }
}

