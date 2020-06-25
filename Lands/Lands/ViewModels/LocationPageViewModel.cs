using Common.Helpers;
using Common.Models;
using Lands.Helpers;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lands.ViewModels
{
    public class LocationPageViewModel : ViewModelBase
    {
        public Land Land { get; set; }
        public LocationPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            Title = $"{Languages.Country}: {Land.Name}";
        }
    }
}
