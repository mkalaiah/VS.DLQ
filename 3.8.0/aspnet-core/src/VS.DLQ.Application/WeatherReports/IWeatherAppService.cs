using System.Threading.Tasks;
using VS.DLQ.WeatherReports.Dto;

namespace VS.DLQ.WeatherReports
{
    interface IWeatherAppService
    {
        Task<WeatherDto> GetWeather(string lat, string lon);
    }
}
