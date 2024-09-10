using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasQueryFilter(u => u.IsEnabled);

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.ShortName)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(u => u.Accuracy)
                .IsRequired()
                .HasMaxLength(10);

            #region Relationships
            builder
                .HasMany(u => u.ItemInBoxes)
                .WithOne(i => i.Unit)
                .HasForeignKey(i => i.UnitId);
            #endregion

            #region CreateAt
            builder
                .Property(u => u.CreateAt)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(u => u.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder
                .Property(u => u.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
