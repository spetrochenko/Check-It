using CheckIt.Core.Utils.BasePage;
using Xamarin.Forms.Xaml;

namespace CheckIt.Core.Components.Main
{
    public class MainPageBase : BasePage<MainViewModel>{}

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MainPageBase
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}