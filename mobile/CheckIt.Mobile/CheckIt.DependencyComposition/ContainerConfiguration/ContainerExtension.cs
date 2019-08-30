using Autofac;
using System;

namespace CheckIt.DependencyComposition.ContainerConfiguration
{
    internal static class ContainerExtension
    {
        public static void ConfigureContainer(this ContainerBuilder containerBuilder, Action<ContainerBuilder> containerAction)
        {
            containerAction(containerBuilder);
        }
    }
}
