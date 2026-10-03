using EFCore_Assignment02.ConfigurationClasses;
using EFCore_Assignment02.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Assignment02.DbContexts
{
    public class ECommerceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        //part01
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //part01
            // Configuration Classes (Apply Configurations)
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new OrderConfigurations());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigurations());
           
        }
    }
}