using Autofac;
using CheckIt.Core.Components.Main;

namespace CheckIt.Core.CoreModule
{
    public sealed class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>();
        }
    }
}
