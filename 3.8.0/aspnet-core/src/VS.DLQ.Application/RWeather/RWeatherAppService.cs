using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using VS.DLQ.WeatherReports.Dto;

namespace VS.DLQ.RWeather
{
    public class RWeatherAppService :  DLQAppServiceBase, IRWeatherAppservice
    {
        public async Task<WeatherDto> GetWeather(string lat, string lon)
        {
            WeatherDto WeatherObj = new WeatherDto();
            //Sign up for a free API key at http://openweathermap.org/appid  
            string key = "ab4311901e90daeca7b398c1806d56ab";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon
                + "&appid=" + key + "&units=imperial";

            WebRequest request = WebRequest.Create(queryString);
            WebResponse webResponse = await request.GetResponseAsync();

            using (Stream webStream = webResponse.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        var results = JObject.Parse(response);

                        if (results["weather"] != null)
                        {
                            WeatherObj.Title = (string)results["name"];
                            WeatherObj.Date = DateTime.Now.ToString("dd/MM/yyyy");
                            var degrees = (Convert.ToDouble((string)results["main"]["temp"]) - 32) * 5 / 9;
                            WeatherObj.Temperature = string.Format("{0}\u00B0C", degrees);
                            WeatherObj.Wind = (string)results["wind"]["speed"] + " mph";
                            WeatherObj.Humidity = (string)results["main"]["humidity"] + " %";
                            WeatherObj.Visibility = (string)results["weather"][0]["main"];
                            DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                            DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                            DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                            WeatherObj.Sunrise = sunrise.ToString() + " UTC";
                            WeatherObj.Sunset = sunset.ToString() + " UTC";
                        }
                    }
                }
            }
            return ObjectMapper.Map<WeatherDto>(WeatherObj);
        }
    }
}
