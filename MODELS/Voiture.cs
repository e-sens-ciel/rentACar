using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Voiture
    {
        public int VoitureID { get; set; }
        public string Immatriculation { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public double Kilometrage { get; set; }
        public string Notoriete { get; set; }
        public int Fk_DepotID { get; set; }

    }
}
