using Microsoft.EntityFrameworkCore;
using Sikurs_DataAccess;
using Sikurs_DataAccess.Base;
using ItemAttribute = Sikurs_DataAccess.ItemAttribute;
using ReleaseVersion = Sikurs_DataAccess.ReleaseVersion;

namespace Sikurs_API.DataBase
{
    public class SikursDbContext : DbContext
    {
        public DbSet<ItemAttribute> Attributes { get; set; }
        public DbSet<AttributeOfItem> AttributeOfItems { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Gratitude> Gratitudes { get; set; }
        public DbSet<GroupOfItem> GroupsOfItem { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemInBox> ItemsInBox { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Permission>  Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReleaseVersion> Versions { get; set; }

        public override int SaveChanges()
        {
            UpdateTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateTimestamps()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                var entity = (BaseEntity)entityEntry.Entity;

                if (entityEntry.State == EntityState.Added)
                {
                    entity.CreateAt = DateTime.Now;
                }

                entity.UpdateAt = DateTime.Now;
            }
        }
    }
}
