using Microsoft.EntityFrameworkCore;

namespace SearchGear.Models
{
    public class SearchGearContext : DbContext
    {
        public SearchGearContext(DbContextOptions<SearchGearContext> options)
            : base(options)
        {
        }

        public DbSet<Gear> Gears { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Gear>()
              .HasData(
                  new Gear { GearId = 1, Brand = "Osprey", Model = "Aether 55", Price = 219 },
                  new Gear { GearId = 2, Brand = "Arcteryx", Model = "Alpha SV", Price = 599 },
                  new Gear { GearId = 3, Brand = "Leki", Model = "Trekking Poles", Price = 139 },
                  new Gear { GearId = 4, Brand = "MSR", Model = "Pocket Rocket", Price = 49 },
                  new Gear { GearId = 5, Brand = "Lowa", Model = "Weisshorn", Price = 499 }
              );
        }
    }
}