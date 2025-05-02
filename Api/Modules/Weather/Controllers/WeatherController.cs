using Microsoft.AspNetCore.Mvc;

using Api.Modules.Weather.Services;

namespace Api.Modules.Weather.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<string>>> GetForecasts()
        {
            var forecast = await _weatherService.GetForecastAsync();
            return Ok(forecast);
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<User>> GetUser(int id)
        // {
        //     var user = await _weatherService.GetUserByIdAsync(id);
        //     if (user == null) return NotFound();
        //     return Ok(user);
        // }

        // [HttpPost]
        // public async Task<ActionResult<User>> CreateUser(User user)
        // {
        //     var createdUser = await _weatherService.CreateUserAsync(user);
        //     return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        // }
    }
}
