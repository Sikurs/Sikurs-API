using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .Property(d => d.Id)
                .IsRequired()
                .HasMaxLength(36)
                .ValueGeneratedOnAdd();

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(d => d.Role)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(d => d.SiteUrl)
                .HasMaxLength(250);

            builder
                .Property(d => d.PictureUrl)
                .HasMaxLength(250);
        }
    }
}
