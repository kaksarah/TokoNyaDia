using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoNyaDia2.Entities;

namespace TokoNyaDia2.Repositories
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }

        //public DbSet<Products> products { get; set; }
        //public DbSet<ProductPrice> productPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LENOVO-PC\\SQLEXPRESS; Database=StoreDB; Trusted_Connection = True; TrustServerCertificate = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customers>()
        //        .HasIndex(customers => customers.CustomerPhone)
        //        .IsUnique();
        //    modelBuilder.Entity<Customers>()
        //        .HasIndex(customers => customers.CustomerEmail)
        //        .IsUnique();

        //    modelBuilder.Entity<Store>(entity =>
        //    {
        //        entity.HasIndex(stores => stores.StorePhone).IsUnique();
        //        entity.HasIndex(stores => stores.SiupNumber).IsUnique();
        //    });
        //}
    }
}
