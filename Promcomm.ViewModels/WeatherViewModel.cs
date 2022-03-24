using System.ComponentModel.DataAnnotations;

namespace Promcomm.ViewModels
{
    public class WeatherViewModel
    {
        public string? Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }

        [Required]
        public string? Summary { get; set; }
        public string IsMorning { get; set; }
    }
}