
namespace Promcomm.Services
{
    using AutoMapper;
    using Promcomm.Entities;
    using Promcomm.Services.Contracts;
    using Promcomm.ViewModels;

    public class WeatherForecastServices : IWeatherForecastServices
    {
        private readonly IMapper _mapper;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public WeatherViewModel GetbyId(int id)
        {
            WeatherForecast weather = new WeatherForecast();
            weather.Summary = Summaries[id];
            weather.TemperatureC = Random.Shared.Next(-20, 55);
            weather.Date = DateTime.Now;
            weather.IsMorning = DateTime.Now.Hour < 12;
            return _mapper.Map<WeatherForecast, WeatherViewModel>(weather);
        }

        public IEnumerable<WeatherViewModel> Get()
        {
            var WeatherForecastList = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();

            return _mapper.Map<IEnumerable<WeatherForecast>, IEnumerable<WeatherViewModel>>(WeatherForecastList);
        }
    }
}