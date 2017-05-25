using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using xamarin.fun.core.ViewModels;

namespace xamarin.fun.core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}
