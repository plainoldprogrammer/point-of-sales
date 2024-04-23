using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using ConsoleAppDatabaseAccess.Models;

namespace ConsoleAppDatabaseAccess.Context
{
    public class PointOfSalesContext : DbContext
    {
        private String databasePath = "C:\\PointOfSales";
        private String databaseName = "pos_database.sqlite";
        public DbSet<Product> Products { get; set; }

        public PointOfSalesContext() : base()
        {
            Directory.CreateDirectory(databasePath);
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={databasePath}\\{databaseName};");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(p => new { p.Name })
                .IsUnique();
        }
    }
}
