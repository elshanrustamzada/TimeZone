using Microsoft.EntityFrameworkCore;
using TimeZone.Models;

namespace TimeZone.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
