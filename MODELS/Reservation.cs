using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double PrixTotal { get; set; }
        public bool Remise { get; set; }
        public int Fk_ClientID { get; set; }
        public int Fk_DepotArriveeID { get; set; }
        public int Fk_DepotDepartID { get; set; }
        public int Fk_VoitureID { get; set; }

        //public class Reservations
        //{
        //    public List<Reservation> reservations { get; set; }
        //}
    }
}
