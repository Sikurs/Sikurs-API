using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ItemAttribute = Sikurs_DataAccess.ItemAttribute;

namespace Sikurs_API.DataBase.Configurations
{
    public class ItemAttributeConfiguration : IEntityTypeConfiguration<ItemAttribute>
    {
        public void Configure(EntityTypeBuilder<ItemAttribute> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(a => a.GroupOfItemId)
                .IsRequired()
                .HasMaxLength(36);

            #region Relationships
            builder
                    .HasOne(a => a.GroupOfItem)
                    .WithMany(g => g.Attributes)
                    .HasForeignKey(a => a.GroupOfItemId)
                    .IsRequired();

            builder
                .HasMany(a => a.AttributeOfItems)
                .WithOne(a => a.Attribute)
                .HasForeignKey(a => a.AttributeId); 
            #endregion

            #region CreateAt
            builder.Property(a => a.CreateAt)
                    .ValueGeneratedOnAdd();

            builder.Property(a => a.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd(); 
            #endregion

            #region UpdateAt
            builder.Property(a => a.UpdateAt)
                    .ValueGeneratedOnAddOrUpdate();

            builder.Property(a => a.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
