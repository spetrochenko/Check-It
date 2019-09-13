using Autofac;
using CheckIt.Core.Components.AccountCredential;
using CheckIt.Core.Components.Main;
using CheckIt.Core.Components.NameCredential;
using CheckIt.Core.Utils.BaseViewModel;
using CheckIt.Core.Utils.Command;
using CheckIt.Core.Utils.Navigation;

namespace CheckIt.Core.CoreModule
{
    public sealed class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AccountPageParameters>().AsSelf();
            builder.RegisterType<AccountPageParameters>().As<BasePageParameters>();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainViewModel>().As<BaseModel>();
            builder.RegisterType<NameViewModel>().AsSelf();
            builder.RegisterType<NameViewModel>().As<BaseModel>();
            builder.RegisterType<AccountViewModel>().AsSelf();
            builder.RegisterType<AccountViewModel>().As<ParameterizedBaseModel<AccountPageParameters>>();

            builder.RegisterType<BaseCommand>().AsSelf();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
        }
    }
}
