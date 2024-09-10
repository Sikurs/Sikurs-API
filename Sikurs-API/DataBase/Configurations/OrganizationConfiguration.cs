using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasQueryFilter(o => o.IsEnabled);

            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(o => o.SiteUrl)
                .HasMaxLength(250);

            builder
                .Property(o => o.PictureUrl)
                .HasMaxLength(250);


            builder
                .Property(o => o.ResponsibleUserId)
                .HasMaxLength(36);

            #region Relationships
            builder
                .HasOne(o => o.ResponsibleUser)
                .WithMany(u => u.ResponsibleOrganizations)
                .HasForeignKey(o => o.ResponsibleUserId);

            builder
                .HasMany(o => o.Collections)
                .WithOne(c => c.Organization)
                .HasForeignKey(c => c.OrganizationId);

            builder
                .HasMany(o => o.Users)
                .WithOne(u => u.Organization)
                .HasForeignKey(u => u.OrganizationId);
            #endregion

            #region CreateAt
            builder
                .Property(o => o.CreateAt)
                .ValueGeneratedOnAdd();

            builder
                .Property(o => o.CreateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();
            #endregion

            #region UpdateAt
            builder
                .Property(o => o.UpdateAt)
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(o => o.UpdateById)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAddOrUpdate();
            #endregion
        }
    }
}
