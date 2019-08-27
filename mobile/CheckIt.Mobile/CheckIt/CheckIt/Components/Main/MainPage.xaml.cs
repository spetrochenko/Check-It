using CheckIt.Common.Container;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckIt.Core.Components.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = AppContainer.Get<MainViewModel>();
        }
    }
}