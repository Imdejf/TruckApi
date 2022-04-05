using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Truck.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
        }


        [HttpGet("/GetTruck")]
        public async Task<IActionResult> GetAllTruck()
        {
            TruckLibrary.Truck truck = new TruckLibrary.Truck();

            return Ok(await truck.GetAllTruckAsync());


        }

        [HttpGet("/GetTruckPosition")]
        public async Task<IActionResult> GetAllTruckPosition()
        {
            TruckLibrary.Truck truck = new TruckLibrary.Truck();

            return Ok(await truck.GetAllPositionTruckAsync());
        }
    }
}