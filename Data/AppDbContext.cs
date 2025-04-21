using ApiSampleCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSampleCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Login> Login { get; set; }

    }
}
