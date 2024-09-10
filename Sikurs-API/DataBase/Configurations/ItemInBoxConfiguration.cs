using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class ItemInBoxConfiguration : IEntityTypeConfiguration<ItemInBox>
    {
        public void Configure(EntityTypeBuilder<ItemInBox> builder)
        {
            builder.HasQueryFilter(i => i.IsEnabled);

            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.Count)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(i => i.ItemId)
                .HasMaxLength(36);

            builder
                .Property(i => i.BoxId)
                .IsRequired()
                .HasMaxLength(36);

            builder
                .Property(i => i.UnitId)
                .IsRequired()
                .HasMaxLength(36);

            #region Relationships
            builder
                .HasOne(i => i.Item)
                .WithMany(i => i.ItemInBoxes)
                .HasForeignKey(i => i.ItemId);

            builder
                .HasOne(i => i.Box)
                .WithMany(b => b.ItemsInBox)
                .HasForeignKey(i => i.BoxId)
                .IsRequired();

            builder
                .HasOne(i => i.Unit)
                .WithMany(u => u.ItemInBoxes)
                .HasForeignKey(i => i.UnitId)
                .IsRequired();

            #endregion

            #region CreateAt
            builder
                .Property(i => i.CreateAt)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(i => i.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder
                .Property(i => i.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
