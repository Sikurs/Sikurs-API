using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class ReleaseVersionConfiguration : IEntityTypeConfiguration<ReleaseVersion>
    {
        public void Configure(EntityTypeBuilder<ReleaseVersion> builder)
        {
            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.CurrentReleaseVersion)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(v => v.Description)
                .HasMaxLength(500);

            builder
                .Property(u => u.ReleasedAt)
                .ValueGeneratedOnAdd();
        }
    }
}
