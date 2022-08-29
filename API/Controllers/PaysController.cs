using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using MODELS;

namespace API.Controllers
{
    public class PaysController : ControllerBase
    {


        private readonly PaysQuery _pays;
        public PaysController(PaysQuery paysQuery)
        {
            _pays = paysQuery;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllPays()
        {
            List<Pays> pays = _pays.GetAll();
            return Ok(pays);
        }

        [HttpGet("{id}")]
        public IActionResult GetPays (int id)
        {
            Pays pays = _pays.GetById(id);
            return Ok(pays);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePays(Pays pays)
        {
            _pays.UpdatePays(pays);

            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult Createpays(Pays pays)
        {
            _pays.Create(pays);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult Deletedepot(int id)
        {
            _pays.Delete(id);
            return Ok();
        }


    }
}
