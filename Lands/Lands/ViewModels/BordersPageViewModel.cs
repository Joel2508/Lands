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
    public class BordersPageViewModel : ViewModelBase
    {
        public Land Land { get; set; }
        private ObservableCollection<Border> borders;

        public ObservableCollection<Border> Borders
        {
            set => SetProperty(ref borders, value);
            get => borders;
        }

        public BordersPageViewModel(INavigationService navigationService):base(navigationService)
        {
            
            Title = Languages.Borders;
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            LoadBordes();
        }

        private void LoadBordes()
        {
            var bordes = JsonConvert.DeserializeObject<Land>(Settings.Land).Borders;
            Borders = new ObservableCollection<Border>();
            foreach (var borde in bordes)
            {
                Borders.Add(new Border
                {
                    Code = borde,
                    Name = borde
                });
            }
        }
    }
}
