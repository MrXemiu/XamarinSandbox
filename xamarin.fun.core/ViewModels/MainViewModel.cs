using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace xamarin.fun.core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;


        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        /// <inheritdoc />
        public override void Start()
        {
            base.Start();
            _navigationService.Navigate<ViewModelA>();
        }
    }
}
