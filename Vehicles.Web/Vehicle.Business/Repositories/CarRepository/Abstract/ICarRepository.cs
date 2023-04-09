using Vehicles.Domain.Classes.BaseClasses;
using Vehicles.Domain.Classes.DbClasses;

namespace Vehicle.Business.Repositories.CarRepository.Abstract
{
    public interface ICarRepository
    {   
        List<Car> GetByColor(string color);
        void LightSetting(int id);
        void DeleteVehicle(int id);
    }
}
