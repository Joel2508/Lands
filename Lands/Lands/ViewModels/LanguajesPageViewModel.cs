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
    public class LanguajesPageViewModel : ViewModelBase
    {
        private ObservableCollection<Language> languages;
        public Land Land { get; set; }
        public ObservableCollection<Language> Languages
        {
            set => SetProperty(ref languages, value);
            get => languages;
        }
        public LanguajesPageViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = Helpers.Languages.MyLanguages;
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            Languages = new ObservableCollection<Language>(Land.Languages);
        }
    }
}
