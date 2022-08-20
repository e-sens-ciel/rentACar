namespace Web.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double PrixTotal { get; set; }
        public bool Remise { get; set; }
    }

    //public class Reservations
    //{
    //    public List<Reservation> allReservations { get; set; }
    //}
}
