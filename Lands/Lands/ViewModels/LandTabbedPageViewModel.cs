using Common.Helpers;
using Common.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lands.ViewModels
{
    public class LandTabbedPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private Land _land;
        public LandTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("Land"))
            {
                _land = parameters.GetValue<Land>("Land");
                Settings.Land = JsonConvert.SerializeObject(_land);
                Title = _land.Name;
            }
        }
    }
}
