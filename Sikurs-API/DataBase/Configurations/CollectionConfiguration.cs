using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class CollectionConfiguration : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.OrganizationId)
                .IsRequired()
                .HasMaxLength(36);

            #region Relationships
            builder
                    .HasOne(c => c.Organization)
                    .WithMany(o => o.Collections)
                    .HasForeignKey(c => c.OrganizationId)
                    .IsRequired();

            builder
                .HasMany(c => c.Boxes)
                .WithOne(b => b.Collection)
                .HasForeignKey(b => b.CollectionId);
            #endregion

            #region CreateAt
            builder.Property(c => c.CreateAt)
                    .ValueGeneratedOnAdd();

            builder.Property(c => c.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder.Property(c => c.UpdateAt)
                    .ValueGeneratedOnAddOrUpdate();

            builder.Property(c => c.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
