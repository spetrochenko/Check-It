using CI.Common.Helpers.DbContextHelpers;
using CI.Data.Context.Configuration;
using CI.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CI.Data.Context
{
    internal sealed class DomainContext : DbContext
    {
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Column> Columns { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<TaskDates> TaskDates { get; set; }

        public DbSet<TaskLabel> TaskLabels { get; set; }

        public DbSet<TaskType> TaskTypes { get; set; }

        public DbSet<TaskUsers> TaskUsers { get; set; }

        public DbSet<Tempo> Tempi { get; set; }

        public DbSet<User> Users { get; set; }

        public DomainContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextHelper.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureManyToMany();
        }
    }
}
