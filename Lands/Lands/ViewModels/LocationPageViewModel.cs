using Common.Helpers;
using Common.Models;
using Lands.Helpers;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms.Maps;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace Lands.ViewModels
{
    public class LocationPageViewModel : ViewModelBase
    {
        public Land Land { get; set; }

        private ObservableCollection<Pin> _pins;
        private List<double> _latlng;
        private readonly INavigationService _navigationService;

        public List<double> Latlng
        {
            set => SetProperty(ref _latlng, value);
            get => _latlng;
        }

        public ObservableCollection<Pin> Pins
        {
            set => SetProperty(ref _pins, value);
            get => _pins;
        }
        public LocationPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            Latlng = new List<double>(Land.Latlng);
            Settings.Latlng = JsonConvert.SerializeObject(Latlng);            
            Title = $"{Languages.Country}: {Land.Name}";
            _navigationService = navigationService;
            
        }

        public  ObservableCollection<Pin> LoadPins(ObservableCollection<double> latlng)
        {
            var latitude = latlng[0];
            var longitud = latlng[1];
            Pins = new ObservableCollection<Pin>();
            Pins.Add(new Pin
            {
                Position = new Position(latitude, longitud),
                Label = Languages.Country + " " + Land.Name,
                Address = Languages.Capital + " "+ Land.Capital + " " + Languages.Area + " " + Land.Area + " " + Languages.Timezones + " " + Land.Timezones[0].Substring(5),
                Type = PinType.Place,
            });
            return Pins;
        }
    }
}
