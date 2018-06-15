using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace VS.DLQ.WeatherReports.Dto
{
    [AutoMapTo(typeof(WeatherReport))]
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