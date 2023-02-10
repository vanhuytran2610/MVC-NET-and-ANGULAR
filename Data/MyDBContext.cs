using Microsoft.EntityFrameworkCore;
using NET_Angular.Models;

namespace NET_Angular.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<CartItem> cartItems { get; set; } 
        public DbSet<Order> orders { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<OrderLine> orderLines { get; set; }
        public DbSet<Picture> pictures { get; set; }
    }
}
