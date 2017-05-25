using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxTest.Core.ViewModels
{
    public class ViewModelA : MvxViewModel<string, string>
    {
        private readonly IMvxNavigationService _navigationService;
        private string _parameter;
        private string _result;
        public string Title => "View A";

        public string Parameter
        {
            get => _parameter;
            set => SetProperty(ref _parameter, value);
        }

        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public MvxCommand GoToBCommand => new MvxCommand(async () =>
        {
            Result = await _navigationService.Navigate<ViewModelB, string, string>($"Navigated from {Title}");
        });

        public ViewModelA(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task Initialize(string parameter)
        {
            Parameter = parameter;

            return Task.FromResult(true);
        }
    }
}
