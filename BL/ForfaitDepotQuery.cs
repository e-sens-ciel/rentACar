using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ForfaitDepotQuery
    {
        private readonly CarContext _carContext;
        public ForfaitDepotQuery(CarContext carContext)
        {
            _carContext = carContext;
        }
        public List<ForfaitDepot> GetAll()
        {
            List<ForfaitDepot> forfaitsdepots = _carContext.ForfaitDepot.ToList();

            return forfaitsdepots;
        }

    }
}
