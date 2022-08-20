using Microsoft.EntityFrameworkCore;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options ) : base( options )  
        {
            
        }

        public DbSet<Reservation> Reservation { get; set; }

    }
}
