using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VS.DLQ.WeatherReports.Dto;

namespace VS.DLQ.WeatherReports
{
    public class WeatherAppService : IWeatherAppService
    {
        public async Task<WeatherDto>  GetWeather(string lat, string lon)
        {
            //Sign up for a free API key at http://openweathermap.org/appid  
            string key = "ab4311901e90daeca7b398c1806d56ab";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon
                + "&appid=" + key + "&units=imperial";

            dynamic results = await GetDataFromService(queryString);
            WeatherDto WeatherObj = new WeatherDto();

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
            return WeatherObj;
        }

        public async Task<WeatherDto> GetDataFromService(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();

            //if your response is in json format just uncomment below line  

            //Response.AddHeader("Content-type", "text/json");  

            return new WeatherDto();
        }
    }
}
