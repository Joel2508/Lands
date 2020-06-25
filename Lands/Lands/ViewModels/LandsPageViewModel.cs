using Common.Helpers;
using Common.Interfaces;
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
    public class LandsPageViewModel : ViewModelBase
    {
        private bool _isRefrish;
        private bool _isRunning;
        private DelegateCommand _refreshCommand;
        private readonly INavigationService _navigationService;
        private readonly IApiServices _apiServices;
        private List<LandsItemViewModel> _lands;
        private string _filter;
        private DelegateCommand _searchCommand;
        private List<LandsItemViewModel> listLands;
        public bool IsRefreshing
        {
            get => _isRefrish;
            set => SetProperty(ref _isRefrish, value);
        }
        public bool IsRunning
        {
            set => SetProperty(ref _isRunning, value);
            get => _isRunning;
        }

        public string Filter
        {
            get => _filter;
            set
            {
                SetProperty(ref _filter, value);
                Search();
            }


        }

        public List<LandsItemViewModel> Lands
        {
            get => _lands;
            set => SetProperty(ref _lands, value);
        }

        public DelegateCommand SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand(Search));
        public DelegateCommand RefreshCommand => _refreshCommand ?? (_refreshCommand = new DelegateCommand(Refresh));

        public LandsPageViewModel(INavigationService navigationService, IApiServices apiServices) : base(navigationService)
        {
            Title = Languages.Countries;
            _navigationService = navigationService;
            _apiServices = apiServices;
            LoadCountries();
        }


        private async void LoadCountries()
        {
            if (!_apiServices.CheckConnection())
            {
                Lands = null;
                return;
            }
            IsRunning = true;
            var urlBase = App.Current.Resources["urlBase"].ToString();
            var serviPrefix = App.Current.Resources["serviPrefix"].ToString();
            var controller = App.Current.Resources["controller"].ToString();

            var response = await _apiServices.GestListAsync<LandsItemViewModel>(urlBase, serviPrefix, controller);
            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", response.Message, "Acept");
                IsRunning = false;
                return;
            }
            listLands = (List<LandsItemViewModel>)response.Result;
            Search();

            IsRunning = false;
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(Filter))
            {
                Lands = listLands.Select(l => new LandsItemViewModel(_navigationService)
                {
                    Alpha2Code = l.Alpha2Code,
                    Alpha3Code = l.Alpha3Code,
                    AltSpellings = l.AltSpellings,
                    Area = l.Area,
                    Borders = l.Borders,
                    CallingCodes = l.CallingCodes,
                    Capital = l.Capital,
                    Cioc = l.Cioc,
                    Currencies = l.Currencies,
                    Demonym = l.Demonym,
                    Flag = l.Flag,
                    Gini = l.Gini,
                    Languages = l.Languages,
                    Latlng = l.Latlng,
                    Name = l.Name,
                    NativeName = l.NativeName,
                    NumericCode = l.NumericCode,
                    Population = l.Population,
                    Region = l.Region,
                    RegionalBlocs = l.RegionalBlocs,
                    Subregion = l.Subregion,
                    TopLevelDomain = l.TopLevelDomain,
                    Timezones = l.Timezones,
                    Translations = l.Translations,

                }).ToList();
            }
            else
            {
                Lands = listLands.Select(l => new LandsItemViewModel(_navigationService)
                {
                    Alpha2Code = l.Alpha2Code,
                    Alpha3Code = l.Alpha3Code,
                    AltSpellings = l.AltSpellings,
                    Area = l.Area,
                    Borders = l.Borders,
                    CallingCodes = l.CallingCodes,
                    Capital = l.Capital,
                    Cioc = l.Cioc,
                    Currencies = l.Currencies,
                    Demonym = l.Demonym,
                    Flag = l.Flag,
                    Gini = l.Gini,
                    Languages = l.Languages,
                    Latlng = l.Latlng,
                    Name = l.Name,
                    NativeName = l.NativeName,
                    NumericCode = l.NumericCode,
                    Population = l.Population,
                    Region = l.Region,
                    RegionalBlocs = l.RegionalBlocs,
                    Subregion = l.Subregion,
                    TopLevelDomain = l.TopLevelDomain,
                    Timezones = l.Timezones,
                    Translations = l.Translations,

                }).Where(t => t.Name.ToUpper().Contains(Filter.ToUpper()) || t.Capital.ToUpper().Contains(Filter.ToUpper())).ToList();
            }
            Settings.Countries = JsonConvert.SerializeObject(Lands);
            
        }


        private void Refresh()
        {
            LoadCountries();
            IsRefreshing = false;
        }        
    }
}
