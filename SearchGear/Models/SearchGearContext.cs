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
                  new Gear { GearId = 1, Family = "Backpacks", Brand = "Osprey", Model = "Aether 55", Price = 219 },
                  new Gear { GearId = 2, Family = "Outerwear", Brand = "Arcteryx", Model = "Alpha SV", Price = 599 },
                  new Gear { GearId = 3, Family = "Accessories", Brand = "Leki", Model = "Trekking Poles", Price = 139 },
                  new Gear { GearId = 4, Family = "Cooking", Brand = "MSR", Model = "Pocket Rocket", Price = 49 },
                  new Gear { GearId = 5, Family = "Footwear", Brand = "Lowa", Model = "Weisshorn", Price = 499 }
              );
        }
    }
}