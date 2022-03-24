using AutoMapper;
using Promcomm.Entities;
using Promcomm.ViewModels;

namespace Promcomm.WebAPI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ClearPrefixes();
            RecognizePrefixes("tmp");
            CreateMap<WeatherForecast, WeatherViewModel>();//.ForMember(x=>x.IsMorning, y => y.MapFrom(src => src.IsMorning ? "TRUE" : "FALSE"));

            CreateMap<WeatherViewModel, WeatherForecast>();
            //CreateMap<WeatherForecast, WeatherViewModel>();//.ForMember(x => x.IsMorning, m => m.MapFrom(src => src.IsMorning ? "Yes" : "No"));

            //CreateMap<List<WeatherForecast>, List<WeatherViewModel>>();
        }
    }
}
