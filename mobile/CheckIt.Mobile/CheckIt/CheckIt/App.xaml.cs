using CheckIt.Core.Components.AccountCredential;
using CheckIt.Core.Components.Main;
using CheckIt.Core.Components.NameCredential;
using CheckIt.Core.Utils.Navigation;
using Xamarin.Forms.Xaml;
using static CheckIt.Common.Container.AppContainer;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CheckIt.Core
{
    public partial class App
    {
        private readonly INavigationService navigationService;

        public App()
        {
            InitializeComponent();
            MainPage = new Components.Main.MainPage();

            navigationService = Get<INavigationService>();
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
            navigationService.Configure(nameof(AccountCredential), typeof(AccountCredential));
            navigationService.Configure(nameof(NameCredential), typeof(NameCredential));

            navigationService.SetRootPage(nameof(Components.Main.MainPage));
        }
    }
}
