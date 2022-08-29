namespace Web.Models
{
    public class Depot
    {
        public int DepotID { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Email { get; set; }

        public int Fk_PaysID { get; set; }

    }
}
