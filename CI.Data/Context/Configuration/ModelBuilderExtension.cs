using CI.Models.Models.ResolveModels;
using Microsoft.EntityFrameworkCore;

namespace CI.Data.Context.Configuration
{
    public static class ModelBuilderExtension
    {
        public static void ConfigureManyToMany(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoles>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserRoles>()
                .HasOne(u => u.Role)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.RoleId);
        }
    }
}
