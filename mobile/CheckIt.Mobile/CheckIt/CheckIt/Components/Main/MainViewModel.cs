using CheckIt.Common.Entities;
using CheckIt.Core.Command;
using CheckIt.Data.Repository.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CheckIt.Core.BaseViewModel;

namespace CheckIt.Core.Components.Main
{
    public class MainViewModel : BaseModel
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
            ClearInput();
        }

        private void ClearInput()
        {
            FirstName = null;
            LastName = null;
            Email = null;
            Password = null;
        }

        private IEnumerable<User> GetUsers()
        {
            return repository.Load();
        }

        public override async Task InitAsync()
        {
            var users = await Task.Run(() => GetUsers());
            Users = new ObservableCollection<User>(users);
        }
    }
}
