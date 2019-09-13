using CheckIt.Common.Entities;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Command;
using CheckIt.Core.Utils.Navigation;
using CheckIt.Data.Repository.Interface;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckIt.Core.Components.AccountCredential
{
    public sealed class AccountViewModel : ParameterizedBaseModel<AccountPageParameters>
    {
        public string SuggestedEmail { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand AddUser { get; set; }

        private readonly IGenericRepository<User> repository;
        private readonly INavigationService navigationService;

        public AccountViewModel(IGenericRepository<User> repository, INavigationService navigationService)
        {
            this.repository = repository;
            this.navigationService = navigationService;
        }

        private string CreateEmail()
        {
            if (FirstName != null && LastName != null)
            {
                return FirstName + "_" + LastName + "@gmail.com";
            }

            return "The name and surname has not been enter";
        }

        private async void CreateNewUser(object obj)
        {


            await navigationService.NavigateAsync(nameof(Main.MainPage));
        }

        public override async Task InitAsync(AccountPageParameters parameter)
        {
            await Task.Run(() => AddUser = new BaseCommand(CreateNewUser));
            SuggestedEmail = CreateEmail();
        }
    }
}
