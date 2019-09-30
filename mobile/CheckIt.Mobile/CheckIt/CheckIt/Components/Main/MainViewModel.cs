using CheckIt.Common.Entities;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Command;
using CheckIt.Core.Utils.Navigation;
using CheckIt.Core.Utils.ObservableCollectionExtension;
using CheckIt.Data.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckIt.Core.Components.Main
{
    public sealed class MainViewModel : BaseModel
    {
        public ICommand OpenCreationPage { get; set; }

        public ExtendedObservableCollection<User> Users { get; set; }

        private readonly IGenericRepository<User> repository;
        private readonly INavigationService navigationService;

        public MainViewModel(IGenericRepository<User> repository, INavigationService navigationService)
        {
            this.repository = repository;
            this.navigationService = navigationService;
            Users = new ExtendedObservableCollection<User>();
        }

        private async void OpenNewPage(object obj)
        {
            await navigationService.NavigateAsync(nameof(NameCredential.NameCredential));
        }

        private IEnumerable<User> GetUsers()
        {
            return repository.Load();
        }

        public override async Task InitAsync()
        {
            var users = await Task.Run(() => GetUsers());
            Users.AddRange(users);
            OpenCreationPage = new BaseCommand(OpenNewPage);
        }
    }
}
