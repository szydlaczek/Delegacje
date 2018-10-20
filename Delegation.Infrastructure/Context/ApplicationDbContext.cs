using Delegation.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext() : base()
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()             
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("db"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasKey(r=>r.Id);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            var navigation = modelBuilder.Entity<Role>()
                .Metadata.FindNavigation(nameof(Role.UsersInRole));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
