using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class GroupOfItemConfiguration : IEntityTypeConfiguration<GroupOfItem>
    {
        public void Configure(EntityTypeBuilder<GroupOfItem> builder)
        {
            builder.HasQueryFilter(g => g.IsEnabled);

            builder.HasKey(g => g.Id);

            builder
                .Property(g => g.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(g => g.PictureUrl)
                .HasMaxLength(250);

            #region Relationships
            builder
                .HasMany(g => g.Attributes)
                .WithOne(a => a.GroupOfItem)
                .HasForeignKey(a => a.GroupOfItemId);

            builder.HasOne(g => g.Parent)
                .WithMany(g => g.GroupsOfItem)
                .HasForeignKey(g => g.ParentId);

            builder
                .HasMany(g => g.Items)
                .WithOne(i => i.GroupOfItem)
                .HasForeignKey(i => i.GroupOfItemId);

            builder
                .HasMany(g => g.Boxes)
                .WithOne(b => b.GroupOfItem)
                .HasForeignKey(b => b.GroupOfItemId);
            #endregion

            #region CreateAt
            builder
                .Property(g => g.CreateAt)
                .ValueGeneratedOnAdd();

            builder
                .Property(g => g.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(g => g.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(g => g.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
