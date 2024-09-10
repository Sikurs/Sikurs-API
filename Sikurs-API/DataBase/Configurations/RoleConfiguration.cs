using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasQueryFilter(r => r.IsEnabled);

            builder.HasKey(r => r.Id);

            builder
                .Property(r => r.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(r => r.Description)
                .HasMaxLength(250);

            #region Relationships
            builder
                .HasMany(r => r.Permissions)
                .WithOne(p => p.Role)
                .HasForeignKey(p => p.RoleId);

            builder
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId);
            #endregion

            #region CreateAt
            builder
                .Property(r => r.CreateAt)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(r => r.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(r => r.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
