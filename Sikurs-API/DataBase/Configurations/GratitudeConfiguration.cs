using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class GratitudeConfiguration : IEntityTypeConfiguration<Gratitude>
    {
        public void Configure(EntityTypeBuilder<Gratitude> builder)
        {
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
                .Property(g => g.Reason)
                .IsRequired()
                .HasMaxLength(250);

            builder
                .Property(g => g.SiteUrl)
                .HasMaxLength(250);

            builder
                .Property(g => g.PictureUrl)
                .HasMaxLength(250);
        }
    }
}
