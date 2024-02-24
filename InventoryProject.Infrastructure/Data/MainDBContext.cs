using InventoryProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryProject.Infrastructure.Data
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
