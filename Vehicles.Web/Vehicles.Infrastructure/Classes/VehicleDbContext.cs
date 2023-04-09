using Microsoft.EntityFrameworkCore;
using Vehicles.Domain.Classes.BaseClasses;
using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Infrastructure.Classes

{
    public class VehicleDbContext : DbContext
    {
        protected VehicleDbContext()
        {
        }
        public VehicleDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
               new Car { Id = 1, Color = "black", LightOn = false, Wheel = 4 },
               new Car { Id = 2, Color = "red", LightOn = true, Wheel = 4 }
            );

            modelBuilder.Entity<Bus>().HasData(
              new Bus { Id = 4, Color = "yellow", LightOn = true, Wheel = 6 },
              new Bus { Id = 5, Color = "blue", LightOn = false, Wheel = 8 }
            );

            modelBuilder.Entity<Boat>().HasData(
                new Boat { Id = 3, Color = "white", Capacity = 4 }
            );
        }
    }
}
