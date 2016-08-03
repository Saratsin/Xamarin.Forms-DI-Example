using System;
namespace DI
{
    public class MountainAreaViewModel
    {
        IMountainWeatherService _mountainWeatherService;

        public string Name { get; set; }

        public MountainAreaViewModel(Location location, IMountainWeatherService mountainWeatherService)
        {
            _mountainWeatherService = mountainWeatherService;
            Name = location.Name;
        }
    }
}

