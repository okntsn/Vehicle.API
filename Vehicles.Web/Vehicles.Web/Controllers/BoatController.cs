using Microsoft.AspNetCore.Mvc;
using Vehicles.Business.Repositories.BoatRepository.Abstract;
using Vehicles.Domain.Classes.DbClasses;

namespace Vehicles.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : Controller
    {
        private readonly IBoatRepository _boatRepository;

        public BoatController(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }
        [HttpGet("boats")]
        public IActionResult GetBotsByColor(string color)
        {
            var current = _boatRepository.GetByColor(color).OfType<Boat>().ToList();
            if (current.Count == 0)
                return NotFound();

            return Ok(current);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            _boatRepository.DeleteVehicle(id);
            return Ok();

        }
    }
}
