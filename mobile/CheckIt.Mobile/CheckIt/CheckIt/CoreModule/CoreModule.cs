using Autofac;
using CheckIt.Core.Components.Main;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Command;
using CheckIt.Core.Utils.Navigation;

namespace CheckIt.Core.CoreModule
{
    public sealed class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainViewModel>().As<BaseModel>();
            builder.RegisterType<BaseCommand>().AsSelf();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
        }
    }
}
