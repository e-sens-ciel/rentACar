using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class ForfaitDepot
    {
        public int ForfaitDepotID { get; set; }
        public double Prix { get; set; }
        public int FK_DepotDepartID { get; set; }
        public int FK_DepotArriveeID { get; set; }
        public int FK_NoteID { get; set; }


    }
}
