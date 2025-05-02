using Xunit;
using Api.Modules.Weather.Services;
using System.Linq;

namespace Api.Tests.Modules.Weather.Services
{
    public class WeatherServiceTests
    {
        [Fact]
        public async void GetForecastAsync_Returns_WeatherData()
        {
            // Arrange
            var service = new WeatherService();

            // Act
            var result = await service.GetForecastAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Contains("Sunny", result);
            Assert.Contains("Cloudy", result);
        }
    }
}