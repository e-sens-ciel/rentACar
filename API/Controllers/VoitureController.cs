using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MODELS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoitureController : ControllerBase
    {
        private readonly VoitureQuery _voitures;
        public VoitureController(VoitureQuery voitureQuery)
        {
            _voitures = voitureQuery;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllVoitures()
        {
            List<Voiture> voitures = _voitures.GetAll();
            return Ok(voitures);
        }


        [HttpGet("{id}")]
        public IActionResult GetVoiture(int id)
        {

            Voiture voiture = _voitures.GetById(id);
            return Ok(voiture);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVoiture(Voiture voiture)
        {
            _voitures.UpdateVoiture(voiture);

            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult CreateVoiture(Voiture voiture)
        {
            _voitures.Create(voiture);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteVoiture(int id)
        {
            _voitures.Delete(id);
            return Ok();
        }
    }
}
