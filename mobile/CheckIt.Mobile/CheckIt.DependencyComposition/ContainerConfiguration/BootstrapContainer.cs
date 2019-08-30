using Autofac;
using CheckIt.Common.CommonModule;
using CheckIt.Core.CoreModule;
using CheckIt.Data.DataModule;

namespace CheckIt.DependencyComposition.ContainerConfiguration
{
    public class BootstrapContainer
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.ConfigureContainer(container =>
            {
                container.RegisterModule<CoreModule>();
                container.RegisterModule<DataModule>();
                container.RegisterModule<CommonModule>();
            });

            return containerBuilder.Build();
        }
    }
}
