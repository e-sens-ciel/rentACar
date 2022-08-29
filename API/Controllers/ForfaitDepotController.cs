using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using MODELS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForfaitDepotController : ControllerBase
    {
        private readonly ForfaitDepotQuery _forfaitdepot;
        public ForfaitDepotController(ForfaitDepotQuery ForfaitDepotQuery)
        {
            _forfaitdepot = ForfaitDepotQuery;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllForfaitDepot()
        {
            List<ForfaitDepot> forfaitdepots = _forfaitdepot.GetAll();
            return Ok(forfaitdepots);
        }


        //[HttpGet("{id}")]
        //public IActionResult GetReservation(int id)
        //{

        //    Reservation reservation = _forfaitdepot.GetById(id);
        //    return Ok(reservation);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateReservation(Reservation reservation)
        //{
        //    _forfaitdepot.UpdateReservation(reservation);

        //    return Ok();
        //}

        //[HttpPost("[action]")]
        //public IActionResult CreateReservation(Reservation reservation)
        //{
        //    _forfaitdepot.Create(reservation);
        //    return Ok();
        //}

        //[HttpDelete("[action]")]
        //public IActionResult DeleteReservation(int id)
        //{
        //    _forfaitdepot.Delete(id);
        //    return Ok();
        //}
    }
}
