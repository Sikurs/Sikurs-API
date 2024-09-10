using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasQueryFilter(p => p.IsEnabled);

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Entity)
                .IsRequired()
                .HasMaxLength(50);

            #region Create
            builder
                .Property(p => p.CanCreate)
                .IsRequired();

            builder
                .Property(p => p.CreateScope)
                .IsRequired();
            #endregion

            #region Read
            builder
                .Property(p => p.CanRead)
                .IsRequired();

            builder
                .Property(p => p.ReadScope)
                .IsRequired();
            #endregion

            #region Update
            builder
                .Property(p => p.CanUpdate)
                .IsRequired();

            builder
                .Property(p => p.UpdateScope)
                .IsRequired();
            #endregion

            #region Delete
            builder
                .Property(p => p.CanDelete)
                .IsRequired();

            builder
                .Property(p => p.DeleteScope)
                .IsRequired(); 
            #endregion



            #region Relationships
            builder
                .HasOne(p => p.Role)
                .WithMany(r => r.Permissions)
                .HasForeignKey(p => p.RoleId);
            #endregion

            #region CreateAt
            builder
                .Property(p => p.CreateAt)
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(p => p.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder
                .Property(p => p.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
