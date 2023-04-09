using Microsoft.Extensions.DependencyInjection;
using Vehicle.Business.Repositories.CarRepository.Abstract;
using Vehicle.Business.Repositories.CarRepository.Concrete;
using Vehicles.Business.Repositories.BoatRepository.Abstract;
using Vehicles.Business.Repositories.BoatRepository.Concrete;
using Vehicles.Business.Repositories.BusRepository.Abstract;
using Vehicles.Business.Repositories.BusRepository.Concrete;

namespace Vehicles.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVehiclesBusiness(this IServiceCollection service)
        {
            service.AddTransient<ICarRepository, CarRepository>();
            service.AddTransient<IBusRepository, BusRepository>();
            service.AddTransient<IBoatRepository, BoatRepository>();
            return service;
        }
    }
}

