using Microsoft.EntityFrameworkCore;

namespace Lab4.Models
{
    public class CarRentDBContext:DbContext
    {
        public CarRentDBContext(DbContextOptions<CarRentDBContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
