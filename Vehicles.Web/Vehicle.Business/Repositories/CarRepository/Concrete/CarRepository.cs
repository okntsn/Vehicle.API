using Vehicle.Business.Repositories.CarRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;
using Vehicles.Infrastructure.Classes;

namespace Vehicle.Business.Repositories.CarRepository.Concrete
{
    public class CarRepository : ICarRepository
    {
        
        private readonly VehicleDbContext _vehicleDbContext;

        public CarRepository(VehicleDbContext vehicleDbContext) 
        {
            _vehicleDbContext = vehicleDbContext;
        }

        public void DeleteVehicle(int id)
        {
            var current = _vehicleDbContext.Cars.FirstOrDefault(x => x.Id == id);
            if (current != null)
                _vehicleDbContext.Remove(current);        
        }

        public List<Car> GetByColor(string color)
        {
           return _vehicleDbContext.Cars.Where(t=> t.Color == color).ToList();
        }

        public void LightSetting(int id)
        {
            var current = _vehicleDbContext.Cars.FirstOrDefault(x => x.Id == id);
            if (current != null)
                current.LightOn = !current.LightOn;
        }
    }
}
