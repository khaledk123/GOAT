using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using DTOs.Objects;
namespace DAL
{
    public class GoatContext:DbContext
    {
        public GoatContext(DbContextOptions<GoatContext> options) : base(options)
        {

        }

        public GoatContext() {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("config.json")
            .Build();

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:GoatDBConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Sale>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Seller>();
            modelBuilder.Entity<Category>();
        }

        public DbSet<Product> Products;
        public DbSet<Category> Categories;
        public DbSet<Sale> Sales;
        public DbSet<Customer> Customers;
        public DbSet<Seller> Sellers;

    }
}
