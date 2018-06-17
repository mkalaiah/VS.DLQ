using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DLQMobileApp.Models;

namespace DLQMobileApp.ViewModels
{
    public class WeatherViewModel
    {
        public static Weather WeatherObj;

        public WeatherViewModel ()
        {
            
        }

        public async Task<dynamic> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }

            return data;
        }

        public async Task GetWeather(string lat, string lon)
        {
            //Sign up for a free API key at http://openweathermap.org/appid  
            string key = "ab4311901e90daeca7b398c1806d56ab";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon
                + "&appid=" + key + "&units=imperial";

            dynamic results = await GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                WeatherObj = new Weather();
                WeatherObj.Title = (string)results["name"];
                WeatherObj.Date = DateTime.Now.ToString("dd/MM/yyyy");
                var degrees = (Convert.ToDouble((string)results["main"]["temp"]) - 32)*5/9;
                WeatherObj.Temperature = string.Format("{0:0.00}\u00B0C", degrees);
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
