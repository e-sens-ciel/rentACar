using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VoitureQuery
    {
        private readonly CarContext _carContext;
        public VoitureQuery(CarContext carContext)
        {
            _carContext = carContext;
        }

        public List<Voiture> GetAll()
        {
            List<Voiture> voitures = _carContext.Voiture.ToList();
            return voitures;
        }


        public Voiture GetById(int id)
        {
            Voiture voiture = _carContext.Voiture.Find(id);

            if (voiture == null)
            {
                throw new NotImplementedException();
            }

            return voiture;
        }

        public async Task<IActionResult> Create(Voiture voiture)
        {
            if (voiture == null)
            {
                throw new NotImplementedException();
            }
            _carContext.Voiture.Add(voiture);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }
        public async Task UpdateVoiture(Voiture voiture)
        {
            _carContext.Entry(voiture).State = EntityState.Modified;
            await _carContext.SaveChangesAsync();
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }
            List<Voiture> voitures = _carContext.Voiture.ToList();
            var reserv = voitures.Find(x => x.VoitureID == id);
            var removed = _carContext.Voiture.Remove(reserv);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }
    }
}
