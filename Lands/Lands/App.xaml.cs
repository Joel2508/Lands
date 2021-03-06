using Prism;
using Prism.Ioc;
using Lands.ViewModels;
using Lands.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Common.Interfaces;
using Common.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lands
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/NavigationPage/LandsPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiServices, ApiServices>();
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IGeolocatorService, GeolocatorService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();            
            containerRegistry.RegisterForNavigation<LandsPage, LandsPageViewModel>();            
            containerRegistry.RegisterForNavigation<LandPage, LandPageViewModel>();
            containerRegistry.RegisterForNavigation<BordersPage, BordersPageViewModel>();
            containerRegistry.RegisterForNavigation<CurrenciesPage, CurrenciesPageViewModel>();
            containerRegistry.RegisterForNavigation<TranlationsPage, TranlationsPageViewModel>();
            containerRegistry.RegisterForNavigation<LanguajesPage, LanguajesPageViewModel>();
            containerRegistry.RegisterForNavigation<LocationPage, LocationPageViewModel>();
            containerRegistry.RegisterForNavigation<LandTabbedPage, LandTabbedPageViewModel>();
        }
    }
}
