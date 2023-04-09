using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Business.Repositories.BoatRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;
using Vehicles.Infrastructure.Classes;

namespace Vehicles.Business.Repositories.BoatRepository.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        private readonly VehicleDbContext _vehicleDbContext;

        public BoatRepository(VehicleDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }
        public void DeleteVehicle(int id)
        {
            var current = _vehicleDbContext.Boats.FirstOrDefault(x => x.Id == id);
            if (current != null)
                _vehicleDbContext.Remove(current);
        }
        public List<Boat> GetByColor(string color)
        {
            return _vehicleDbContext.Boats.Where(t => t.Color == color).ToList();
        }

    }
}
