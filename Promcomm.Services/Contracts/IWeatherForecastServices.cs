
namespace Promcomm.Services.Contracts
{
    using Promcomm.ViewModels;

    public interface IWeatherForecastServices
    {
        IEnumerable<WeatherViewModel> Get();
        WeatherViewModel GetbyId(int id);
    }
}
