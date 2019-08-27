using Autofac;

namespace CheckIt.DependencyComposition.ContainerConfiguration
{
    public class BootstrapContainer
    {
        public IContainer CreateContainer(Module module = null)
        {
            var containerBuilder = new ContainerBuilder();

            if (module != null)
            {
                containerBuilder.RegisterModule(module);
            }

            RegisterDependencies.Registry(containerBuilder);
            return containerBuilder.Build();
        }
    }
}
