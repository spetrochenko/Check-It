using Autofac;

namespace CheckIt.DependencyComposition.ContainerConfiguration
{
    public class BootstrapContainer
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies.Registry(containerBuilder);
            return containerBuilder.Build();
        }
    }
}
