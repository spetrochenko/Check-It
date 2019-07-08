﻿using CI.Common.Helpers.DbContextHelpers;
using CI.Data.Context.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CI.Data.Context
{
    internal sealed class DomainContext : DbContext
    {
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
