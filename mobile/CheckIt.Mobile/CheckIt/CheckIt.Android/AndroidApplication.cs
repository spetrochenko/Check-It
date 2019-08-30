
using Android.App;
using CheckIt.Common.Container;
using CheckIt.DependencyComposition.ContainerConfiguration;

namespace CheckIt.Droid
{
    internal class AndroidApplication : Application
    {
        public override void OnCreate()
        {
            var container = new BootstrapContainer();

            AppContainer.Container = container.CreateContainer();
        }
    }
}