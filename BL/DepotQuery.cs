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
    public class DepotQuery
    {
        private readonly CarContext _carContext;
        public DepotQuery(CarContext carContext)
        {
            _carContext = carContext;
        }

        public List<Depot> GetAll()
        {
            List<Depot> depots = _carContext.Depot.ToList();
            return depots;
        }


        public Depot GetById(int id)
        {
            Depot depot = _carContext.Depot.Find(id);

            if (depot == null)
            {
                throw new NotImplementedException();
            }

            return depot;
        }

        public async Task<IActionResult> Create(Depot depot)
        {
            if (depot == null)
            {
                throw new NotImplementedException();
            }
            _carContext.Depot.Add(depot);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }
        public async Task UpdateDepot(Depot depot)
        {
            _carContext.Entry(depot).State = EntityState.Modified;
            await _carContext.SaveChangesAsync();
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }
            List<Depot> depots = _carContext.Depot.ToList();
            var dep = depots.Find(x => x.DepotID == id);
            var removed = _carContext.Depot.Remove(dep);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }

    }
}
