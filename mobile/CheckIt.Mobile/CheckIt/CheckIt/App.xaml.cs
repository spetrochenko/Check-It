using CheckIt.Core.Components.Main;
using CheckIt.Core.Utils.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CheckIt.Core
{
    public partial class App : Application
    {
        private readonly INavigationService navigationService;

        public App(INavigationService navigationService)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            this.navigationService = navigationService;
        }

        protected override void OnStart()
        {
            SetUpNavigation();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void SetUpNavigation()
        {
            navigationService.Configure(nameof(Components.Main.MainPage), typeof(MainPage));
            navigationService.Configure(nameof(MainPageBase), typeof(MainPageBase));
            navigationService.SetRootPage(nameof(MainPageBase));
        }
    }
}
