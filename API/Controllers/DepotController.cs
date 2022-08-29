using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using MODELS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepotController : ControllerBase
    {
            private readonly DepotQuery _depots;
            public DepotController(DepotQuery depotQuery)
            {
                _depots = depotQuery;
            }

            [HttpGet("[action]")]
            public IActionResult GetAllDepots()
            {
                List<Depot> depots = _depots.GetAll();
                return Ok(depots);
            }

        [HttpGet("{id}")]
        public IActionResult GetDepot(int id)
        {

            Depot depot = _depots.GetById(id);
            return Ok(depot);
        }

        [HttpPut("{id}")]
        public IActionResult Updatedepot(Depot depot)
        {
            _depots.UpdateDepot(depot);

            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult Createdepot(Depot depot)
        {
            _depots.Create(depot);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult Deletedepot(int id)
        {
            _depots.Delete(id);
            return Ok();
        }
    }
}
