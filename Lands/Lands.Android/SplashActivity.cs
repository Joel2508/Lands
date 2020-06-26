
using Android.App;
using Android.OS;

namespace Lands.Droid
{
    [Activity(Theme = "@style/Theme.Splash", Label = "Países", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(1800);
            StartActivity(typeof(MainActivity));
        }
    }
}