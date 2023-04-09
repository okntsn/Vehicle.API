using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Business.Repositories.BusRepository.Abstract
{
    public interface IBusRepository
    {
        List<Bus> GetByColor(string color);
        void LightSetting(int id);
        void DeleteVehicle(int id);
    }
}
