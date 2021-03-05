using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Description).HasMaxLength(EfCoreConstraintsConstants.DescriptionMaxLenght);

            //date def

            builder.ToTable("ProductComments");
        }
    }
}

