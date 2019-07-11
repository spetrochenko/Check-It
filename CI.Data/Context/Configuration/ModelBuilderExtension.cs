using CI.Models.Models;
using CI.Models.Models.ResolveModels;
using Microsoft.EntityFrameworkCore;

namespace CI.Data.Context.Configuration
{
    public static class ModelBuilderExtension
    {
        public static void ConfigureManyToMany(this ModelBuilder modelBuilder)
        {
            #region UserRoles

            modelBuilder.Entity<UserRoles>().HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRoles>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserRoles>()
                .HasOne(u => u.Role)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.RoleId);

            #endregion

            #region UserBoards

            modelBuilder.Entity<UserBoards>().HasKey(ub => new { ub.UserId, ub.BoardId });

            modelBuilder.Entity<UserBoards>()
                .HasOne(u => u.User)
                .WithMany(u => u.UserBoards)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserBoards>()
                .HasOne(u => u.Board)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.BoardId);

            #endregion
        }

        public static void AddInitialData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role[]
                {
                    new Role{Id = 1, Title = "Lead"},
                    new Role{Id = 2, Title = "Dev"}
                });
        }
    }
}
