using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using xamarin.fun.core.ViewModels;

namespace xamarin.fun.droid
{
    [Activity(
        Label = "Xamarin MVVMCross", 
        MainLauncher = true,
        Theme = "@style/Theme.Xamarin.Fun",
        LaunchMode = LaunchMode.SingleTop, 
        Name = "xamarin.fun.droid.activies.MainActivity")]
	public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }
    }
}

