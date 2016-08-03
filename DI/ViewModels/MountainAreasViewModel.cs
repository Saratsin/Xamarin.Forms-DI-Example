using System.Collections.Generic;
using System;
using System.Linq;

namespace DI
{
    public class MountainAreasViewModel
    {
        readonly IMountainWeatherService _mountainWeatherService;
        readonly Func<Location, MountainAreaViewModel> _areaViewModelFactory;

        public string Title { get; set; }

        public IEnumerable<MountainAreaViewModel> Areas { get; set; }

        public MountainAreasViewModel(IMountainWeatherService mountainWeatherService, Func<Location, MountainAreaViewModel> areaViewModelFactory)
        {
            _areaViewModelFactory = areaViewModelFactory;
            _mountainWeatherService = mountainWeatherService;
            Title = "Mountain Areas";
            GetAreas();
        }

        void GetAreas()
        {
            var areas = _mountainWeatherService.GetAreas();
            Areas = areas.Select(location => _areaViewModelFactory(location)).ToList();
        }
   }
}

