using CheckIt.Common.Entities;
using CheckIt.Core.Command;
using CheckIt.Core.ViewModelsMarker;
using CheckIt.Data.Repository.Interface;
using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckIt.Core.Components.Main
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : IViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ObservableCollection<User> Users { get; set; }

        public ICommand AddUser { get; }

        private readonly IGenericRepository<User> repository;

        public MainViewModel(IGenericRepository<User> repository)
        {
            this.repository = repository;

            AddUser = new BaseCommand(CreateUser);
        }

        private void CreateUser(object obj)
        {
            var user = new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password
            };

            Users.Add(user);
            repository.Create(user);
        }

        private IEnumerable<User> GetUsers()
        {
            return repository.Load();
        }

        public async Task InitAsync()
        {
            var users = await Task.Run(() => GetUsers());
            Users = new ObservableCollection<User>(users);
        }
    }
}
