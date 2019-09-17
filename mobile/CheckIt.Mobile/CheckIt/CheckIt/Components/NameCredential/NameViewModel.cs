using CheckIt.Core.Components.AccountCredential;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Command;
using CheckIt.Core.Utils.Navigation;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckIt.Core.Components.NameCredential
{
    public sealed class NameViewModel : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICommand OpenNextPage { get; set; }

        private readonly INavigationService navigationService;

        public NameViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override async Task InitAsync()
        {
            await Task.Run(() => OpenNextPage = new BaseCommand(OpenNewPage));
        }

        private async void OpenNewPage(object obj)
        {
            var parameters = new AccountPageParameters
            {
                FirstName = this.FirstName,
                LastName = this.LastName
            };

            await navigationService.NavigateAsync(nameof(AccountCredential.AccountCredential), parameters);
        }
    }
}

