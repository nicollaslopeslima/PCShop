using PCShop.Models;
using Microsoft.EntityFrameworkCore;

namespace PCShop.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
    }
}
