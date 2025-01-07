using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> optionsDB)
            : base(optionsDB)
        {

        }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>().ToTable("Beer");
            modelBuilder.Entity<Brand>().ToTable("Brand");
        }
    }
}
