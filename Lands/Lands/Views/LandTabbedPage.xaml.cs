using Prism.Navigation;
using Xamarin.Forms;

namespace Lands.Views
{
    public partial class LandTabbedPage : TabbedPage, INavigatedAware
    {
        public LandTabbedPage()
        {
            InitializeComponent();
        }
        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.New)
            {
                if (Children.Count == 1)
                {
                    return;
                }
                for (int pageIndex = 0; pageIndex < Children.Count; pageIndex++)
                {
                    var page = Children[pageIndex];
                    (page?.BindingContext as INavigatedAware)?.OnNavigatedTo(parameters);
                }
            }
        }
    }
}
