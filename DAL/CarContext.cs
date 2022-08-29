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
        public DbSet<Voiture> Voiture { get; set; }
        public DbSet<ForfaitDepot> ForfaitDepot { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Depot> Depot { get; set; }
        public DbSet<Pays> Pays { get; set; }

    }
}
