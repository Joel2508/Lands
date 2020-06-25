using Common.Helpers;
using Common.Models;
using FFImageLoading.Work;
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
    public class LandPageViewModel : ViewModelBase
    {
        public Land Land { get; set; }

        public LandPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Land = JsonConvert.DeserializeObject<Land>(Settings.Land);
            Title = Languages.Country;

        }

        //private void LoadBorders()
        //{
        //    Borders = new ObservableCollection<Border>();
        //    foreach (var item in Land.Borders)
        //    {

        //        Borders.Add(new Border
        //        {
        //            Code = item,
        //            Name = item,
        //        });

        //        var lands = JsonConvert.DeserializeObject<List<Land>>(Settings.Countries);

        //        if (lands != null)
        //        {
        //            var bordeslist = lands.Where(b => b.Borders.Where(b => b. == item).FirstOrDefault();
        //            foreach (var border in borders)
        //            {
        //            }
        //        }
        //    }

        //}
    }
}
