namespace MODELS
{
    public class Depot
    {
        public int DepotID { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Email { get; set; }
        public int FK_PaysID { get; set; }

    }
}