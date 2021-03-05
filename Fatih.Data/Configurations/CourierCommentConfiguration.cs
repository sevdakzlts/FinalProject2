using Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant;
using Fatih.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fatih.Data.Configurations
{
    public class CourierCommentConfiguration : IEntityTypeConfiguration<CourierComment>
    {
        public void Configure(EntityTypeBuilder<CourierComment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Description).HasMaxLength(EfCoreConstraintsConstants.DescriptionMaxLenght);

            //date def

            builder.ToTable("CourierComments");
        }
    }
}

