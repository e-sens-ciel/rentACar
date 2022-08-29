using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class NoteQuery
    {
        private readonly CarContext _carContext;
        public NoteQuery(CarContext carContext)
        {
            _carContext = carContext;
        }
        public List<Note> GetAll()
        {
            List<Note> notes = _carContext.Note.ToList();

            return notes;
        }
    }
}
