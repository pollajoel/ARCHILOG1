using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using APILibbrary.Core.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using WebApplication2.Attributes;
using APILibbrary.Core.Controllers;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBaseApi<WeatherForecast>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly FatDbContext _db;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,FatDbContext db )
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            var rng = new Random();
            var tab = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();



            return ToJson(tab);


            
            //return Result;
            return tab;
        }


    }
}
