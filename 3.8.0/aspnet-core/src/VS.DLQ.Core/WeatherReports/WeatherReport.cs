using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace VS.DLQ.WeatherReports
{
    [Table("DLQWeatherReports")]
    public class WeatherReport : Entity
    {
        [MaxLength(DLQConsts.MaxNameLength)]
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
