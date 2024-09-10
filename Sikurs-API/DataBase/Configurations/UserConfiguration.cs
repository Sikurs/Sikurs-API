using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasQueryFilter(u => u.IsEnabled);

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.FatherName)
                .HasMaxLength(50);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.PhoneNumber)
                .HasMaxLength(50);

            builder
                .Property(u => u.TelegramId)
                .HasMaxLength(50);

            builder
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.IsBlocked)
                .IsRequired()
                .HasDefaultValue(false);

            builder
                .Property(u => u.RoleId)
                .IsRequired()
                .HasMaxLength(36);

            builder
                .Property(u => u.OrganizationId)
                .IsRequired()
                .HasMaxLength(36);

            #region Relationships
            builder
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.OrganizationId)
                .IsRequired();

            builder
                .HasOne(u => u.Organization)
                .WithMany(o => o.Users)
                .HasForeignKey(u => u.OrganizationId)
                .IsRequired();

            builder
                .HasMany(u => u.ResponsibleOrganizations)
                .WithOne(o => o.ResponsibleUser)
                .HasForeignKey(o => o.ResponsibleUserId);
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
