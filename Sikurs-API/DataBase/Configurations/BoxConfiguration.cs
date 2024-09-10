using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class BoxConfiguration : IEntityTypeConfiguration<Box>
    {
        public void Configure(EntityTypeBuilder<Box> builder)
        {
            builder.HasQueryFilter(b => b.IsEnabled);

            builder.HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(b => b.CollectionId)
                .IsRequired()
                .HasMaxLength(36);

            builder
                .Property(b => b.GroupOfItemId)
                .IsRequired()
                .HasMaxLength(36);

            #region Relationships
            builder
                .HasOne(b => b.Collection)
                .WithMany(c => c.Boxes)
                .HasForeignKey(b => b.CollectionId)
                .IsRequired();

            builder
                .HasOne(b => b.GroupOfItem)
                .WithMany(g => g.Boxes)
                .HasForeignKey(b => b.GroupOfItemId)
                .IsRequired();

            builder
                .HasMany(b => b.ItemsInBox)
                .WithOne(i => i.Box)
                .HasForeignKey(i => i.BoxId);
            #endregion

            #region CreateAt
            builder
                .Property(b => b.CreateAt)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(b => b.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder
                .Property(b => b.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
