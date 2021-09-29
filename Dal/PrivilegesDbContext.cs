using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrivilegesService.Dal
{
    public class PrivilegesDbContext : DbContext
    {

        public PrivilegesDbContext(DbContextOptions<PrivilegesDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PrivilegeEntity> Privileges { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserSettingsEntity> UserSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PrivilegeEntity>()
                .HasKey(entity => new { entity.PrivilegeId });

            modelBuilder
                .Entity<UserEntity>()
                .HasKey(entity => new { entity.UserId });

            modelBuilder
                .Entity<UserSettingsEntity>()
                .HasKey(entity => new { entity.UserSettingsId });
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            ApplyComputed();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ApplyComputed();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        private void ApplyComputed()
        {
            var userId = Guid.Empty;
            var currentTime = DateTimeOffset.Now;

            foreach (var entity in ChangeTracker.Entries<PrivilegeEntity>().ToList())
            {
                switch (entity.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        entity.Entity.IsDeleted = true;
                        entity.State = EntityState.Modified;
                        break;
                    case EntityState.Modified:
                        ApplyModified(entity.Entity, currentTime);
                        break;
                    case EntityState.Added:
                        entity.Entity.IsDeleted = false;
                        ApplyCreated(entity.Entity, currentTime);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void ApplyCreated(PrivilegeEntity entity, DateTimeOffset currentTime)
        {
            entity.CreatedDate = currentTime;
        }

        private void ApplyModified(PrivilegeEntity entity, DateTimeOffset currentTime)
        {
            entity.LastSavedDate = currentTime;
        }
    }
}
