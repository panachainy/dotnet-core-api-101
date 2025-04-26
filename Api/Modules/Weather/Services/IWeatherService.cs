namespace Api.Modules.Weather.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<string>> GetForecastAsync();
    }
}