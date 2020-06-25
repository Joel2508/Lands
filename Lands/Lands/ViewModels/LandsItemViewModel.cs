using Common.Helpers;
using Common.Models;
using Lands.Views;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.Generic;
using System.Linq;

namespace Lands.ViewModels
{
    public class LandsItemViewModel : Land
    {

        private readonly INavigationService _navigationService;
        private DelegateCommand _selectLandCommand;

        public LandsItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public DelegateCommand SelectLandCommand => _selectLandCommand ?? (_selectLandCommand = new DelegateCommand(SelectLandAsync));
        private async void SelectLandAsync()
        {
            var parameters = new NavigationParameters { { "Land", this } };

            string page = $"{nameof(LandTabbedPage)}";
            Settings.Land = JsonConvert.SerializeObject(this);
            

            await _navigationService.NavigateAsync(page, parameters);
        }
    }
}
