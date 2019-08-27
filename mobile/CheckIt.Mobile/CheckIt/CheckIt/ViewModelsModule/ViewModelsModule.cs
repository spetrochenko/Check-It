using Autofac;
using CheckIt.Core.Components.Main;

namespace CheckIt.Core.ViewModelsModule
{
    internal sealed class ViewModelsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>();
        }
    }
}
