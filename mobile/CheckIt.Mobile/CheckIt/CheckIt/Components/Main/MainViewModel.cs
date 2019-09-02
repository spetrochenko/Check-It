using CheckIt.Core.ViewModelsMarker;
using PropertyChanged;

namespace CheckIt.Core.Components.Main
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : IViewModel
    {
        public string MyProperty { get; set; } = "hello";
    }
}
