using Autofac;
using CheckIt.Core.BaseViewModel;
using CheckIt.Core.Command;
using CheckIt.Core.Components.Main;

namespace CheckIt.Core.CoreModule
{
    public sealed class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainViewModel>().As<BaseModel>();
            builder.RegisterType<BaseCommand>().AsSelf();
        }
    }
}
