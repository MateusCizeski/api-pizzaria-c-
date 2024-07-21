using Microsoft.EntityFrameworkCore;
using pizzaria_api.Model;
using pizzaria_api.Model.Category;
using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders;
using pizzaria_api.Model.Products;
using pizzaria_api.Model.Users;

namespace pizzaria_api
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=pizzaria;User Id=postgres;Password=123456");
        }
    }
}
