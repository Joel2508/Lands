using Common.Helpers;
using Common.Interfaces;
using Common.Models;
using Lands.Helpers;
using Lands.ViewModels;
using Newtonsoft.Json;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Lands.Views
{
    public partial class LocationPage : ContentPage
    {
        private readonly IGeolocatorService _geolocatorService;
        private readonly INavigationService _navigationService;        
        public Land Land { get; set; }

        public ObservableCollection<Pin> Pins { get; set; }
        public ObservableCollection<double> Latlng { get; set; }
        public LocationPage(IGeolocatorService geolocatorService, INavigationService navigationService)
        {
            InitializeComponent();
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);

            Position position = new Position(Land.Latlng[0], Land.Latlng[1]);            
            _geolocatorService = geolocatorService;
            _navigationService = navigationService;
            _geolocatorService.Latitude = position.Latitude;
            _geolocatorService.Longitude = position.Longitude;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MoveMapToCurrentPositionAsync();
        }
        private async void MoveMapToCurrentPositionAsync()
        {
            bool isLocationPermision = await CheckLocationPermisionsAsync();

            if (isLocationPermision)
            {
                MyMap.IsShowingUser = true;

                if (_geolocatorService.Latitude != 0 && _geolocatorService.Longitude != 0)
                {
                    Position position = new Position(
                        _geolocatorService.Latitude,
                        _geolocatorService.Longitude);
                    MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        position,
                        Distance.FromKilometers(.5)));
                }
                await _geolocatorService.GetLocationAsync();                
                var location = new LocationPageViewModel(_navigationService);
                
                Latlng = new ObservableCollection<double>(Land.Latlng);
                var load = location.LoadPins(Latlng);
                foreach (var item in load)
                {
                    MyMap.Pins.Add(item);
                }
            }
        }

        private async Task<bool> CheckLocationPermisionsAsync()
        {
            PermissionStatus permissionLocation = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
            PermissionStatus permissionLocationAlways = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationAlways);
            PermissionStatus permissionLocationWhenInUse = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
            bool isLocationEnabled = permissionLocation == PermissionStatus.Granted ||
                                     permissionLocationAlways == PermissionStatus.Granted ||
                                     permissionLocationWhenInUse == PermissionStatus.Granted;
            if (isLocationEnabled)
            {
                return true;
            }

            await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);

            permissionLocation = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
            permissionLocationAlways = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationAlways);
            permissionLocationWhenInUse = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
            return permissionLocation == PermissionStatus.Granted ||
                   permissionLocationAlways == PermissionStatus.Granted ||
                   permissionLocationWhenInUse == PermissionStatus.Granted;
        }
    }

}

