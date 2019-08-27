using PropertyChanged;

namespace CheckIt.Core.Components.Main
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public string MyProperty { get; set; } = "hello";
    }
}
