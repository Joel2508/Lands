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

namespace Lands.ViewModels
{
    public class CurrenciesPageViewModel : ViewModelBase
    {

        private ObservableCollection<Currency> currencies;
        public Land Land { get; set; }
        public ObservableCollection<Currency> Currencies
        {
            set => SetProperty(ref currencies, value);
            get => currencies;
        }
        public CurrenciesPageViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = Languages.Currencies;
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            Currencies = new ObservableCollection<Currency>(Land.Currencies);
            
        }
    }
}
