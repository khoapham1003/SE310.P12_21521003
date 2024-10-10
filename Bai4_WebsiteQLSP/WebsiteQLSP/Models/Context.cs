using Microsoft.EntityFrameworkCore;

namespace WebsiteQLSP.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

