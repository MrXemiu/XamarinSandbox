using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvxTest.Core.ViewModels
{
    public class ViewModelC : MvxViewModel<string, string>
    {
        private string _parameter;
        private string _result;
        public string Title => "View C";

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

        public MvxCommand CloseCommand => new MvxCommand(async () =>
        {
            await Close($"{Title} was closed.");
        });

        public override Task Initialize(string parameter)
        {
            Parameter = parameter;

            return Task.FromResult(true);
        }
    }
}
