using CheckIt.Common.Container;
using CheckIt.Core.Components.Main;
using CheckIt.Core.ViewModelsModule;
using CheckIt.DependencyComposition.ContainerConfiguration;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CheckIt.Source.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var container = new BootstrapContainer();
            AppContainer.Container = container.CreateContainer(new ViewModelsModule());

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
