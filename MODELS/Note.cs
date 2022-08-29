using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Note
    {
        public int NoteID { get; set; }
        public int FK_VoitureID { get; set; }
        public string Description { get; set; }



    }
}
