using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using Web.Models;

namespace Web.Controllers
{
    public class VoitureController : Controller
    {
        public IVoitureService _voitureService;
        public VoitureController(IVoitureService voitureService)
        {
            _voitureService = voitureService;
        }

        public async Task<ActionResult> GetAllVoitures()
        {
            var voitures = await _voitureService.GetAllVoitures();
            return View(voitures);
        }

        public async Task<ActionResult> CreateVoiture()
        {
            return View();
        }
        public async Task<ActionResult> CreateVoitureObj(Voiture voiture)
        {
            await _voitureService.CreateVoitureObj(voiture);
            return RedirectToAction("GetAllVoitures");
        }

        public async Task<ActionResult> GetVoiture(int id)
        {
            var voiture = await _voitureService.GetVoiture(id);
            return View(voiture);
        }

        public async Task<ActionResult> EditVoiture(int id)
        {
            var voiture = await _voitureService.GetVoiture(id);
            return View(voiture);
        }

        public async Task<ActionResult> UpdateVoiture(Voiture voiture)
        {
            await _voitureService.UpdateVoiture(voiture);
            return RedirectToAction("GetAllVoitures");
        }
        public async Task<ActionResult> DeleteVoiture(int id)
        {
            await _voitureService.DeleteVoiture(id);
            return RedirectToAction("GetAllVoitures");
        }


    }
}
