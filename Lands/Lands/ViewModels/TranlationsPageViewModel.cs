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
using System.Net.NetworkInformation;

namespace Lands.ViewModels
{
    public class TranlationsPageViewModel : ViewModelBase
    {
        public Land Land { get; set; }        
        public TranlationsPageViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = Languages.Translations;
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);            
        }
    }
}
