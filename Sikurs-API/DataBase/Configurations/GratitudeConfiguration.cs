using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;

namespace Sikurs_API.DataBase.Configurations
{
    public class GratitudeConfiguration : IEntityTypeConfiguration<Gratitude>
    {
        public void Configure(EntityTypeBuilder<Gratitude> builder)
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
                .Property(a => a.Reason)
                .IsRequired()
                .HasMaxLength(250);

            builder
                .Property(a => a.SiteUrl)
                .HasMaxLength(250);

            builder
                .Property(a => a.PictureUrl)
                .HasMaxLength(250);
        }
    }
}
