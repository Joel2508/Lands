using Common.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    public class LandsItemViewModel : Land
    {
        private DelegateCommand _selectLandCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand SelectLandCommand => _selectLandCommand ?? (_selectLandCommand = new DelegateCommand(SelectLand));
        public LandsItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private void SelectLand()
        {

        }
    }
}
