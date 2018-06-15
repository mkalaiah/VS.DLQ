using System.Threading.Tasks;
using VS.DLQ.WeatherReports.Dto;

namespace VS.DLQ.RWeather
{
    interface IRWeatherAppservice
    {
        Task<WeatherDto> GetWeather(string lat, string lon);
    }
}
