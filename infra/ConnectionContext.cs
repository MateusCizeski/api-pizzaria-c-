using Microsoft.EntityFrameworkCore;
using pizzaria_api.Model.Category;

namespace pizzaria_api
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=pizzaria;User Id=postgres;Password=123456");
        }
    }
}
