using BL;
using Microsoft.AspNetCore.Mvc;
using MODELS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly NoteQuery _note;
        public NoteController(NoteQuery Note)
        {
            _note = Note;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllNotes()
        {
            List<Note> forfaitdepots = _note.GetAll();
            return Ok(forfaitdepots);
        }
    }
}