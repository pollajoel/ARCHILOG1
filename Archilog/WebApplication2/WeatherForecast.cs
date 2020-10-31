using System;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Attributes;
using APILibbrary.Core.Attributes;

namespace WebApplication2
{
    public class WeatherForecast
    {

        public DateTime Date { get; set; }


       
        [NotJson]
        public int TemperatureC { get; set; }
        [NotJson]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Disp(true)]
        public string Summary { get; set; }
    }
}
