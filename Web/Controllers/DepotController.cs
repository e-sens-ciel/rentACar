using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;
using Web.Models;

namespace Web.Controllers
{

        public class DepotController : Controller
        {
            public IDepotService _depotService;
            public DepotController(IDepotService depotService)
            {
                _depotService = depotService;
            }

            public async Task<ActionResult> GetAllDepots()
            {
                var depots = await _depotService.GetAllDepots();
                return View(depots);
            }

        public async Task<ActionResult> CreateDepot()
        {
            return View();
        }
        public async Task<ActionResult> CreateDepotObj(Depot depot)
        {
            await _depotService.CreateDepotObj(depot);
            return RedirectToAction("GetAllDepots");
        }

        public async Task<ActionResult> GetDepot(int id)
        {
            var depot = await _depotService.GetDepot(id);
            return View(depot);
        }

        public async Task<ActionResult> EditDepot(int id)
        {
            var depot = await _depotService.GetDepot(id);
            return View(depot);
        }

        public async Task<ActionResult> UpdateDepot(Depot depot)
        {
            await _depotService.UpdateDepot(depot);
            return RedirectToAction("GetAllDepots");
        }
        public async Task<ActionResult> DeleteDepot(int id)
        {
            await _depotService.DeleteDepot(id);
            return RedirectToAction("GetAllDepots");
        }
    }
}
