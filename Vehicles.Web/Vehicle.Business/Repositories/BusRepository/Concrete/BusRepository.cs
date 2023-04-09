using Vehicles.Business.Repositories.BusRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;
using Vehicles.Infrastructure.Classes;

namespace Vehicles.Business.Repositories.BusRepository.Concrete
{
    public class BusRepository : IBusRepository
    {
        private readonly VehicleDbContext _vehicleDbContext;

        public BusRepository(VehicleDbContext vehicleDbContext)
        {
            _vehicleDbContext = vehicleDbContext;
        }
        public void DeleteVehicle(int id)
        {
            var current = _vehicleDbContext.Buses.FirstOrDefault(x => x.Id == id);
            if (current != null)
                _vehicleDbContext.Remove(current);
        }

        public List<Bus> GetByColor(string color)
        {
            return _vehicleDbContext.Buses.Where(t => t.Color == color).ToList();
        }

        public void LightSetting(int id)
        {
            var current = _vehicleDbContext.Buses.FirstOrDefault(x => x.Id == id);
            if (current != null)
                current.LightOn = !current.LightOn;
        }
    }
}
