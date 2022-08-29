using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MODELS;

namespace BL
{
    public class PaysQuery
    {

        private readonly CarContext _carContext;
        public PaysQuery(CarContext carContext)
        {
            _carContext = carContext;
        }

        public List<Pays> GetAll()
        {
            List<Pays> pays = _carContext.Pays.ToList();
            return pays;
        }


        public Pays GetById(int id)
        {
            Pays pays = _carContext.Pays.Find(id);

            if (pays == null)
            {
                throw new NotImplementedException();
            }

            return pays;
        }

        public async Task<IActionResult> Create(Pays pays)
        {
            if (pays == null)
            {
                throw new NotImplementedException();
            }
            _carContext.Pays.Add(pays);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }
        public async Task UpdatePays(Pays pays)
        {
            _carContext.Entry(pays).State = EntityState.Modified;
            await _carContext.SaveChangesAsync();
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }
            List<Pays> pays = _carContext.Pays.ToList();
            var pay = pays.Find(x => x.PaysID == id);
            var removed = _carContext.Pays.Remove(pay);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }

    }
}
