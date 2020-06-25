using Common.Helpers;
using Common.Models;
using Lands.Views;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lands.ViewModels
{
    public class LandTabbedPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private Land _land;

        private DelegateCommand _locationCommand;
        public LandTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            _land = JsonConvert.DeserializeObject<Land>(Settings.Land);
        }

        public DelegateCommand LocationCommand => _locationCommand ?? (_locationCommand = new DelegateCommand(LocationAsync));
        private async void LocationAsync()
        {
            var parameter = new NavigationParameters { { "land", _land } };
            await _navigationService.NavigateAsync(nameof(LocationPage), parameter);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("Land"))
            {                
                Settings.Land = JsonConvert.SerializeObject(_land);
                Title = _land.Name;
            }
        }
    }
}
