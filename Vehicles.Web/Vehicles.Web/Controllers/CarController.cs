using Microsoft.AspNetCore.Mvc;
using Vehicle.Business.Repositories.CarRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        [HttpGet("cars")]
        public IActionResult GetCarsByColor(string color)
        { 
            var current = _carRepository.GetByColor(color).OfType<Car>().ToList();
            if(current.Count == 0)
                return NotFound();

            return Ok(current);
        }
             
        [HttpPost("{id}/lightSetting")]
        public IActionResult LightSetting (int id)
        {
            _carRepository.LightSetting(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            _carRepository.DeleteVehicle(id);
            return Ok();
            
        }
    }
}
