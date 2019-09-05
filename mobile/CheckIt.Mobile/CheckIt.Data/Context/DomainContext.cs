using CheckIt.Common.DataProvider;
using CheckIt.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace CheckIt.Data.Context
{
    internal sealed class DomainContext : DbContext
    {
        private readonly string databaseName;

        public DbSet<User> Users { get; set; }

        public DomainContext()
        {
            databaseName = DependencyService.Get<IDataProvider>()
                                            .GetPath();

            Database.EnsureCreatedAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"FileName={databaseName}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
