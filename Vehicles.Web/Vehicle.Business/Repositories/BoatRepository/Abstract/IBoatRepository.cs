using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Business.Repositories.BoatRepository.Abstract
{
    public interface IBoatRepository
    {
        List<Boat> GetByColor(string color);
        void DeleteVehicle(int id);
    }
}
