using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Modules.Weather.Services
{
    public class WeatherService
    {
        public async Task<IEnumerable<string>> GetForecastAsync()
        {
            // Example implementation
            return await Task.FromResult(new List<string> { "Sunny", "Cloudy" });
        }
    }
}