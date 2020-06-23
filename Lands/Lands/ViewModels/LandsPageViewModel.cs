using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lands.ViewModels
{
    public class LandsPageViewModel : ViewModelBase
    {
        public LandsPageViewModel(INavigationService navigationService):base(navigationService)
        {

        }
    }
}
