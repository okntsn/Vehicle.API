using Microsoft.AspNetCore.Mvc;
using Vehicles.Business.Repositories.BusRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : Controller
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        [HttpGet("buses")]
        public IActionResult GetBusesByColor(string color)
        {
            var current = _busRepository.GetByColor(color).OfType<Bus>().ToList();
            if (current.Count == 0)
                return NotFound();

            return Ok(current);
        }
        [HttpPost("{id}/lightSetting")]
        public IActionResult LightSetting(int id)
        {
            _busRepository.LightSetting(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            _busRepository.DeleteVehicle(id);
            return Ok();

        }
    }
}
