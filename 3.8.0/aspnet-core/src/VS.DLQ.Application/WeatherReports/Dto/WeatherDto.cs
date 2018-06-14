using System;
using Abp.Application.Services.Dto;

namespace VS.DLQ.WeatherReports.Dto
{
    public class WeatherDto : EntityDto
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public DateTime Time { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}