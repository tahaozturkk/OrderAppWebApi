using Microsoft.EntityFrameworkCore;
using OrderAppWebApi.Models.Entities;

namespace OrderAppWebApi.Context
{
    public class OrderApiContext : DbContext
    {
        public OrderApiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x=>x.ProductId);
            modelBuilder.Entity<OrderDetail>().HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x=>x.OrderId);
            
            
        }

    }
}
