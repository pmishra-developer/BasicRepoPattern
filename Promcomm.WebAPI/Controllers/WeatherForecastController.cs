

namespace Promcomm.WebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Promcomm.Services.Contracts;
    using Promcomm.ViewModels;
    using System.Net;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private IWeatherForecastServices _services;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger, 
            IWeatherForecastServices weatherForecastServices)
        {
            _logger = logger;
            _services = weatherForecastServices;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherViewModel> Get()
        {
            return _services.Get();
        }

        [HttpGet("{id}")]
        public WeatherViewModel Get(int id)
        {
            return _services.GetbyId(id);
        }

        [HttpPut("{id}")]
        public HttpResponseMessage AddNewWeather(long id, WeatherViewModel weatherViewModel)
        {
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }
}