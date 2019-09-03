using System.Collections.ObjectModel;
using CheckIt.Common.Entities;
using CheckIt.Core.ViewModelsMarker;
using PropertyChanged;

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

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
        }
    }
}
