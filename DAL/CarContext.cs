using Microsoft.EntityFrameworkCore;
using MODELS;
using MODELS.Client;

namespace DAL
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options ) : base( options )  
        {
            
        }

        public DbSet<Reservation> Reservation { get; set; }

        //public DbSet<Client> Client { get; set; }
    }
}
