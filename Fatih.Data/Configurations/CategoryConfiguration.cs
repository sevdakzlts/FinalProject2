using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Fatih.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(EfCoreConstraintsConstants.NameMaxLenght);

            builder.ToTable("Categories");
        }
    }
}
