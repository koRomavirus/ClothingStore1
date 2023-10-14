using ClothingStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ClothingStore.Data
{
    public class ApplicationDbContext : DbContext
    {

       
        
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<ProductSale> ProductSales{ get; set; }
        public DbSet<Client> Clients{ get; set; }



    }
}
